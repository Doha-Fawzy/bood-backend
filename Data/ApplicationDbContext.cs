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
                    PasswordHash = "admin123" 
                }
            );

            // Seed 30 Services (6 per Category) using a structured list
            var services = new List<Service>();
            int idCounter = 1;

            var seedData = new Dictionary<ServiceCategory, List<(string TitleEn, string TitleAr, string DescriptionEn, string DescriptionAr, string ImageUrl)>>
            {
                {
                    ServiceCategory.Hospitality, new List<(string, string, string, string, string)>
                    {
                        ("Luxury Hotel Operations", "إدارة عمليات الفنادق الفاخرة", "Comprehensive management for 5-star properties.", "إدارة شاملة للمنشآت ذات الخمس نجوم لضمان أعلى معايير الجودة.", "/assets/bood-design/images/bood-service-1.jpg"),
                        ("Event & Banquet Services", "خدمات الفعاليات والمناسبات", "Seamless execution of high-end events.", "تنفيذ سلس واحترافي للفعاليات والمناسبات الراقية.", "/assets/bood-design/images/bood-service-3.jpg"),
                        ("Concierge Excellence", "خدمات الاستقبال والإرشاد المتميزة", "Premium guest services and personalized experiences.", "خدمات ضيافة استثنائية وتجارب مخصصة تلبي تطلعات ضيوفك.", "/assets/bood-design/images/bood-service-4.jpg"),
                        ("Fine Dining Management", "إدارة المطاعم الفاخرة", "Culinary operations for world-class restaurants.", "إدارة عمليات الطهي وتقديم الطعام للمطاعم ذات المستوى العالمي.", "/assets/bood-design/images/services/hospitality-4.jpg"),
                        ("Spa & Wellness", "خدمات المنتجعات الصحية", "Tranquil operations for luxury spa facilities.", "إدارة هادئة واحترافية لمرافق المنتجعات الصحية الفاخرة.", "/assets/bood-design/images/services/hospitality-5.jpg"),
                        ("Valet & Parking", "خدمات صف السيارات", "Secure and efficient vehicle management.", "إدارة آمنة وفعالة لمركبات الضيوف بأعلى مستويات الاحترافية.", "/assets/bood-design/images/services/hospitality-6.jpg")
                    }
                },
                {
                    ServiceCategory.Cleaning, new List<(string, string, string, string, string)>
                    {
                        ("Deep Cleaning", "التنظيف العميق", "Intensive sanitation for commercial spaces.", "تعقيم مكثف وشامل للمساحات التجارية والمهنية.", "/assets/bood-design/images/bood-service-2.jpg"),
                        ("Daily Janitorial", "النظافة اليومية الشاملة", "Routine maintenance for spotless environments.", "عناية دورية ومستمرة لضمان بيئة عمل خالية من العيوب.", "/assets/bood-design/images/services/cleaning-2.jpg"),
                        ("Window & Glass", "تنظيف النوافذ والواجهات الزجاجية", "Streak-free exterior and interior glass cleaning.", "تنظيف احترافي للزجاج الداخلي والخارجي لضمان رؤية نقية تماماً.", "/assets/bood-design/images/services/cleaning-3.jpg"),
                        ("Carpet Restoration", "العناية بالسجاد والموكيت", "Deep extraction and fabric protection.", "تنظيف عميق وحماية متطورة للأنسجة والمفروشات.", "/assets/bood-design/images/services/cleaning-4.jpg"),
                        ("Industrial Sanitation", "التعقيم الصناعي", "Heavy-duty cleaning for factories and warehouses.", "خدمات تنظيف شاقة مخصصة للمصانع والمستودعات الكبرى.", "/assets/bood-design/images/services/cleaning-5.jpg"),
                        ("Post-Construction", "تنظيف ما بعد البناء", "Removing debris and dust after renovations.", "إزالة المخلفات والأتربة لتهيئة الموقع بعد أعمال الترميم والبناء.", "/assets/bood-design/images/services/cleaning-6.jpg")
                    }
                },
                {
                    ServiceCategory.Maintenance, new List<(string, string, string, string, string)>
                    {
                        ("Preventative Maintenance", "الصيانة الوقائية", "Scheduled checks to ensure uninterrupted operations.", "فحوصات مجدولة لضمان استمرارية العمليات التشغيلية دون انقطاع.", "/assets/bood-design/images/services/maintenance-1.jpg"),
                        ("HVAC Systems", "صيانة أنظمة التكييف والتهوية", "Heating, ventilation, and air conditioning care.", "عناية فائقة بأنظمة التدفئة والتهوية وتكييف الهواء لضمان كفاءتها.", "/assets/bood-design/images/services/maintenance-2.jpg"),
                        ("Electrical Services", "الخدمات الكهربائية", "Safe and reliable power system management.", "إدارة آمنة وموثوقة لأنظمة الطاقة والشبكات الكهربائية.", "/assets/bood-design/images/services/maintenance-3.jpg"),
                        ("Plumbing Solutions", "حلول السباكة المتقدمة", "Comprehensive water system maintenance.", "صيانة شاملة ومتكاملة لأنظمة المياه والصرف الصحي.", "/assets/bood-design/images/services/maintenance-4.jpg"),
                        ("Elevator Maintenance", "صيانة المصاعد والسلالم الكهربائية", "Ensuring safe and smooth vertical transport.", "ضمان عمل أنظمة النقل العمودي بأمان وسلاسة مطلقة.", "/assets/bood-design/images/services/maintenance-5.jpg"),
                        ("24/7 Emergency Repairs", "إصلاحات طارئة على مدار الساعة", "Immediate response for critical infrastructure.", "استجابة فورية وحلول سريعة للبنية التحتية الحيوية في حالات الطوارئ.", "/assets/bood-design/images/services/maintenance-6.jpg")
                    }
                },
                {
                    ServiceCategory.Landscaping, new List<(string, string, string, string, string)>
                    {
                        ("Landscape Design", "تصميم المناظر الطبيعية", "Creating beautiful and sustainable outdoor spaces.", "ابتكار مساحات خارجية خلابة ومستدامة تعكس الرقي.", "/assets/bood-design/images/services/landscaping-1.jpg"),
                        ("Lawn Care", "العناية بالمسطحات الخضراء", "Regular mowing, trimming, and fertilization.", "جز وتشذيب وتسميد دوري للحفاظ على نضارة المساحات الخضراء.", "/assets/bood-design/images/services/landscaping-2.jpg"),
                        ("Irrigation Systems", "أنظمة الري المتطورة", "Efficient water management for greenery.", "إدارة فعالة وذكية للمياه للحفاظ على البيئة الطبيعية.", "/assets/bood-design/images/services/landscaping-3.jpg"),
                        ("Hardscaping", "تنفيذ الأعمال الصلبة في الحدائق", "Patios, walkways, and retaining walls.", "إنشاء وتنسيق الممرات، والباحات، والجدران الاستنادية بدقة.", "/assets/bood-design/images/services/landscaping-4.jpg"),
                        ("Tree Care", "العناية بالأشجار والنباتات", "Pruning, removal, and health assessments.", "تقليم، نقل، وتقييم صحي مستمر للأشجار والنباتات.", "/assets/bood-design/images/services/landscaping-5.jpg"),
                        ("Seasonal Planting", "الزراعة الموسمية", "Vibrant floral displays year-round.", "عروض نباتية نابضة بالحياة تتناسب مع جميع فصول السنة.", "/assets/bood-design/images/services/landscaping-6.jpg")
                    }
                },
                {
                    ServiceCategory.SupportServices, new List<(string, string, string, string, string)>
                    {
                        ("Reception & Front Desk", "خدمات الاستقبال", "Professional first impressions for your business.", "انطباعات أولى احترافية تليق بمستوى أعمالك وشركتك.", "/assets/bood-design/images/bood-service-5.jpg"),
                        ("Mailroom Operations", "إدارة غرف البريد", "Efficient handling of incoming and outgoing post.", "تعامل فعال ودقيق مع البريد الوارد والصادر لضمان سلاسة العمل.", "/assets/bood-design/images/services/support-2.jpg"),
                        ("Office Management", "إدارة المكاتب", "Ensuring smooth day-to-day administrative tasks.", "ضمان سير المهام الإدارية اليومية بكفاءة وانسيابية تامة.", "/assets/bood-design/images/services/support-3.jpg"),
                        ("Security Personnel", "كوادر الحراسة والأمن", "Trained guards to protect your assets.", "طاقم أمني مدرب لحماية ممتلكاتك وتأمين منشأتك بفعالية.", "/assets/bood-design/images/services/support-4.jpg"),
                        ("Pest Control", "مكافحة الآفات", "Safe and effective eradication programs.", "برامج إبادة آمنة وفعالة لضمان بيئة صحية ونظيفة.", "/assets/bood-design/images/services/support-5.jpg"),
                        ("Waste Management", "إدارة النفايات وإعادة التدوير", "Sustainable disposal and recycling solutions.", "حلول مستدامة وآمنة للتخلص من النفايات وإعادة التدوير.", "/assets/bood-design/images/services/support-6.jpg")
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
                        TitleEn = item.TitleEn,
                        TitleAr = item.TitleAr,
                        DescriptionEn = item.DescriptionEn,
                        DescriptionAr = item.DescriptionAr,
                        ImageUrl = item.ImageUrl
                    });
                }
            }

            modelBuilder.Entity<Service>().HasData(services);
        }
    }
}
