using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bood.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { 1, "$2a$11$ExampleHashPlaceholderForAdmin123", "admin" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 0, "Comprehensive management for 5-star properties.", "/assets/bood-design/images/expertise-bg.png", "Luxury Hotel Operations" },
                    { 2, 0, "Seamless execution of high-end events.", "/assets/bood-design/images/hero-bg.png", "Event & Banquet Services" },
                    { 3, 0, "Premium guest services and personalized experiences.", "/assets/bood-design/images/expertise-bg.png", "Concierge Excellence" },
                    { 4, 0, "Culinary operations for world-class restaurants.", "/assets/bood-design/images/hero-bg.png", "Fine Dining Management" },
                    { 5, 0, "Tranquil operations for luxury spa facilities.", "/assets/bood-design/images/expertise-bg.png", "Spa & Wellness" },
                    { 6, 0, "Secure and efficient vehicle management.", "/assets/bood-design/images/hero-bg.png", "Valet & Parking" },
                    { 7, 1, "Intensive sanitation for commercial spaces.", "/assets/bood-design/images/expertise-bg.png", "Deep Cleaning" },
                    { 8, 1, "Routine maintenance for spotless environments.", "/assets/bood-design/images/hero-bg.png", "Daily Janitorial" },
                    { 9, 1, "Streak-free exterior and interior glass cleaning.", "/assets/bood-design/images/expertise-bg.png", "Window & Glass" },
                    { 10, 1, "Deep extraction and fabric protection.", "/assets/bood-design/images/hero-bg.png", "Carpet Restoration" },
                    { 11, 1, "Heavy-duty cleaning for factories and warehouses.", "/assets/bood-design/images/expertise-bg.png", "Industrial Sanitation" },
                    { 12, 1, "Removing debris and dust after renovations.", "/assets/bood-design/images/hero-bg.png", "Post-Construction" },
                    { 13, 2, "Scheduled checks to ensure uninterrupted operations.", "/assets/bood-design/images/expertise-bg.png", "Preventative Maintenance" },
                    { 14, 2, "Heating, ventilation, and air conditioning care.", "/assets/bood-design/images/hero-bg.png", "HVAC Systems" },
                    { 15, 2, "Safe and reliable power system management.", "/assets/bood-design/images/expertise-bg.png", "Electrical Services" },
                    { 16, 2, "Comprehensive water system maintenance.", "/assets/bood-design/images/hero-bg.png", "Plumbing Solutions" },
                    { 17, 2, "Ensuring safe and smooth vertical transport.", "/assets/bood-design/images/expertise-bg.png", "Elevator Maintenance" },
                    { 18, 2, "Immediate response for critical infrastructure.", "/assets/bood-design/images/hero-bg.png", "24/7 Emergency Repairs" },
                    { 19, 3, "Creating beautiful and sustainable outdoor spaces.", "/assets/bood-design/images/expertise-bg.png", "Landscape Design" },
                    { 20, 3, "Regular mowing, trimming, and fertilization.", "/assets/bood-design/images/hero-bg.png", "Lawn Care" },
                    { 21, 3, "Efficient water management for greenery.", "/assets/bood-design/images/expertise-bg.png", "Irrigation Systems" },
                    { 22, 3, "Patios, walkways, and retaining walls.", "/assets/bood-design/images/hero-bg.png", "Hardscaping" },
                    { 23, 3, "Pruning, removal, and health assessments.", "/assets/bood-design/images/expertise-bg.png", "Tree Care" },
                    { 24, 3, "Vibrant floral displays year-round.", "/assets/bood-design/images/hero-bg.png", "Seasonal Planting" },
                    { 25, 4, "Professional first impressions for your business.", "/assets/bood-design/images/expertise-bg.png", "Reception & Front Desk" },
                    { 26, 4, "Efficient handling of incoming and outgoing post.", "/assets/bood-design/images/hero-bg.png", "Mailroom Operations" },
                    { 27, 4, "Ensuring smooth day-to-day administrative tasks.", "/assets/bood-design/images/expertise-bg.png", "Office Management" },
                    { 28, 4, "Trained guards to protect your assets.", "/assets/bood-design/images/hero-bg.png", "Security Personnel" },
                    { 29, 4, "Safe and effective eradication programs.", "/assets/bood-design/images/expertise-bg.png", "Pest Control" },
                    { 30, 4, "Sustainable disposal and recycling solutions.", "/assets/bood-design/images/hero-bg.png", "Waste Management" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
