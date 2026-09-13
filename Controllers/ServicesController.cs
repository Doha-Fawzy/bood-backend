using Bood.Api.Data;
using Bood.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ServicesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: api/Services (Publicly accessible)
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Service>>> GetServices()
        {
            return await _context.Services.ToListAsync();
        }

        // GET: api/Services/5 (Publicly accessible)
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Service>> GetService(int id)
        {
            var service = await _context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return service;
        }

        // GET: api/Services/category/{categoryName} (Publicly accessible)
        [HttpGet("category/{categoryName}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Service>>> GetServicesByCategory(string categoryName)
        {
            if (!Enum.TryParse<ServiceCategory>(categoryName, true, out var parsedCategory))
            {
                return BadRequest($"Invalid category name: {categoryName}");
            }

            var services = await _context.Services
                .Where(s => s.Category == parsedCategory)
                .ToListAsync();

            return Ok(services);
        }

        // POST: api/Services/upload-image (Admin only)
        [HttpPost("upload-image")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UploadImage(IFormFile file, [FromForm] string folderName = "services")
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            // Basic validation
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp", ".svg" };
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!allowedExtensions.Contains(extension))
                return BadRequest("Invalid file type.");

            var fileExtension = Path.GetExtension(file.FileName);
            var uniqueFileName = $"{Guid.NewGuid()}{fileExtension}";
            
            var webRootPath = _env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            if (string.IsNullOrWhiteSpace(folderName)) folderName = "services";

            var targetFolder = Path.Combine(webRootPath, "uploads", folderName);
            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            // Physical path for saving the file to wwwroot
            var physicalPath = Path.Combine(targetFolder, uniqueFileName);

            // Save file
            using (var stream = new FileStream(physicalPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Relative path for the database
            var relativeDbPath = $"/uploads/{folderName}/{uniqueFileName}".Replace("\\", "/");

            return Ok(new { url = relativeDbPath });
        }

        // POST: api/Services (Admin only)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Service>> CreateService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetServices), new { id = service.Id }, service);
        }

        // PUT: api/Services/5 (Admin only)
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateService(int id, Service service)
        {
            if (id != service.Id) return BadRequest();

            _context.Entry(service).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Services.Any(e => e.Id == id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // DELETE: api/Services/5 (Admin only)
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null) return NotFound();

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
