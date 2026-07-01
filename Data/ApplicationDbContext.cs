using Microsoft.EntityFrameworkCore;
using Bood.Api.Models;

namespace Bood.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed a default Admin user
            modelBuilder.Entity<Admin>().HasData(
                new Admin 
                { 
                    Id = 1, 
                    Username = "admin", 
                    PasswordHash = "$2a$11$ExampleHashPlaceholderForAdmin123" 
                }
            );

            // Seed 30 Services (6 per Category) using a structured list
            var services = new List<Service>();
            int idCounter = 1;

            var seedData = new Dictionary<ServiceCategory, List<(string Title, string Description, string ImageUrl)>>
            {
                {
                    ServiceCategory.Hospitality, new List<(string, string, string)>
                    {
                        ("Luxury Hotel Operations", "Comprehensive management for 5-star properties.", "/assets/bood-design/images/services/hospitality-1.jpg"),
                        ("Event & Banquet Services", "Seamless execution of high-end events.", "/assets/bood-design/images/services/hospitality-2.jpg"),
                        ("Concierge Excellence", "Premium guest services and personalized experiences.", "/assets/bood-design/images/services/hospitality-3.jpg"),
                        ("Fine Dining Management", "Culinary operations for world-class restaurants.", "/assets/bood-design/images/services/hospitality-4.jpg"),
                        ("Spa & Wellness", "Tranquil operations for luxury spa facilities.", "/assets/bood-design/images/services/hospitality-5.jpg"),
                        ("Valet & Parking", "Secure and efficient vehicle management.", "/assets/bood-design/images/services/hospitality-6.jpg")
                    }
                },
                {
                    ServiceCategory.Cleaning, new List<(string, string, string)>
                    {
                        ("Deep Cleaning", "Intensive sanitation for commercial spaces.", "/assets/bood-design/images/services/cleaning-1.jpg"),
                        ("Daily Janitorial", "Routine maintenance for spotless environments.", "/assets/bood-design/images/services/cleaning-2.jpg"),
                        ("Window & Glass", "Streak-free exterior and interior glass cleaning.", "/assets/bood-design/images/services/cleaning-3.jpg"),
                        ("Carpet Restoration", "Deep extraction and fabric protection.", "/assets/bood-design/images/services/cleaning-4.jpg"),
                        ("Industrial Sanitation", "Heavy-duty cleaning for factories and warehouses.", "/assets/bood-design/images/services/cleaning-5.jpg"),
                        ("Post-Construction", "Removing debris and dust after renovations.", "/assets/bood-design/images/services/cleaning-6.jpg")
                    }
                },
                {
                    ServiceCategory.Maintenance, new List<(string, string, string)>
                    {
                        ("Preventative Maintenance", "Scheduled checks to ensure uninterrupted operations.", "/assets/bood-design/images/services/maintenance-1.jpg"),
                        ("HVAC Systems", "Heating, ventilation, and air conditioning care.", "/assets/bood-design/images/services/maintenance-2.jpg"),
                        ("Electrical Services", "Safe and reliable power system management.", "/assets/bood-design/images/services/maintenance-3.jpg"),
                        ("Plumbing Solutions", "Comprehensive water system maintenance.", "/assets/bood-design/images/services/maintenance-4.jpg"),
                        ("Elevator Maintenance", "Ensuring safe and smooth vertical transport.", "/assets/bood-design/images/services/maintenance-5.jpg"),
                        ("24/7 Emergency Repairs", "Immediate response for critical infrastructure.", "/assets/bood-design/images/services/maintenance-6.jpg")
                    }
                },
                {
                    ServiceCategory.Landscaping, new List<(string, string, string)>
                    {
                        ("Landscape Design", "Creating beautiful and sustainable outdoor spaces.", "/assets/bood-design/images/services/landscaping-1.jpg"),
                        ("Lawn Care", "Regular mowing, trimming, and fertilization.", "/assets/bood-design/images/services/landscaping-2.jpg"),
                        ("Irrigation Systems", "Efficient water management for greenery.", "/assets/bood-design/images/services/landscaping-3.jpg"),
                        ("Hardscaping", "Patios, walkways, and retaining walls.", "/assets/bood-design/images/services/landscaping-4.jpg"),
                        ("Tree Care", "Pruning, removal, and health assessments.", "/assets/bood-design/images/services/landscaping-5.jpg"),
                        ("Seasonal Planting", "Vibrant floral displays year-round.", "/assets/bood-design/images/services/landscaping-6.jpg")
                    }
                },
                {
                    ServiceCategory.SupportServices, new List<(string, string, string)>
                    {
                        ("Reception & Front Desk", "Professional first impressions for your business.", "/assets/bood-design/images/services/support-1.jpg"),
                        ("Mailroom Operations", "Efficient handling of incoming and outgoing post.", "/assets/bood-design/images/services/support-2.jpg"),
                        ("Office Management", "Ensuring smooth day-to-day administrative tasks.", "/assets/bood-design/images/services/support-3.jpg"),
                        ("Security Personnel", "Trained guards to protect your assets.", "/assets/bood-design/images/services/support-4.jpg"),
                        ("Pest Control", "Safe and effective eradication programs.", "/assets/bood-design/images/services/support-5.jpg"),
                        ("Waste Management", "Sustainable disposal and recycling solutions.", "/assets/bood-design/images/services/support-6.jpg")
                    }
                }
            };

            foreach (var categoryPair in seedData)
            {
                var category = categoryPair.Key;
                var items = categoryPair.Value;

                foreach (var item in items)
                {
                    services.Add(new Service
                    {
                        Id = idCounter++,
                        Category = category,
                        Title = item.Title,
                        Description = item.Description,
                        ImageUrl = item.ImageUrl
                    });
                }
            }

            modelBuilder.Entity<Service>().HasData(services);
        }
    }
}
