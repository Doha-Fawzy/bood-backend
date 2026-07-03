using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bood.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddBilingualFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Services",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Services",
                newName: "DescriptionEn");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إدارة شاملة للمنشآت ذات الخمس نجوم لضمان أعلى معايير الجودة.", "إدارة عمليات الفنادق الفاخرة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "تنفيذ سلس واحترافي للفعاليات والمناسبات الراقية.", "خدمات الفعاليات والمناسبات" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "خدمات ضيافة استثنائية وتجارب مخصصة تلبي تطلعات ضيوفك.", "خدمات الاستقبال والإرشاد المتميزة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إدارة عمليات الطهي وتقديم الطعام للمطاعم ذات المستوى العالمي.", "إدارة المطاعم الفاخرة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إدارة هادئة واحترافية لمرافق المنتجعات الصحية الفاخرة.", "خدمات المنتجعات الصحية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إدارة آمنة وفعالة لمركبات الضيوف بأعلى مستويات الاحترافية.", "خدمات صف السيارات" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "تعقيم مكثف وشامل للمساحات التجارية والمهنية.", "التنظيف العميق" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "عناية دورية ومستمرة لضمان بيئة عمل خالية من العيوب.", "النظافة اليومية الشاملة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "تنظيف احترافي للزجاج الداخلي والخارجي لضمان رؤية نقية تماماً.", "تنظيف النوافذ والواجهات الزجاجية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "تنظيف عميق وحماية متطورة للأنسجة والمفروشات.", "العناية بالسجاد والموكيت" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "خدمات تنظيف شاقة مخصصة للمصانع والمستودعات الكبرى.", "التعقيم الصناعي" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إزالة المخلفات والأتربة لتهيئة الموقع بعد أعمال الترميم والبناء.", "تنظيف ما بعد البناء" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "فحوصات مجدولة لضمان استمرارية العمليات التشغيلية دون انقطاع.", "الصيانة الوقائية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "عناية فائقة بأنظمة التدفئة والتهوية وتكييف الهواء لضمان كفاءتها.", "صيانة أنظمة التكييف والتهوية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إدارة آمنة وموثوقة لأنظمة الطاقة والشبكات الكهربائية.", "الخدمات الكهربائية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "صيانة شاملة ومتكاملة لأنظمة المياه والصرف الصحي.", "حلول السباكة المتقدمة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "ضمان عمل أنظمة النقل العمودي بأمان وسلاسة مطلقة.", "صيانة المصاعد والسلالم الكهربائية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "استجابة فورية وحلول سريعة للبنية التحتية الحيوية في حالات الطوارئ.", "إصلاحات طارئة على مدار الساعة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "ابتكار مساحات خارجية خلابة ومستدامة تعكس الرقي.", "تصميم المناظر الطبيعية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "جز وتشذيب وتسميد دوري للحفاظ على نضارة المساحات الخضراء.", "العناية بالمسطحات الخضراء" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إدارة فعالة وذكية للمياه للحفاظ على البيئة الطبيعية.", "أنظمة الري المتطورة" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "إنشاء وتنسيق الممرات، والباحات، والجدران الاستنادية بدقة.", "تنفيذ الأعمال الصلبة في الحدائق" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "تقليم، نقل، وتقييم صحي مستمر للأشجار والنباتات.", "العناية بالأشجار والنباتات" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "عروض نباتية نابضة بالحياة تتناسب مع جميع فصول السنة.", "الزراعة الموسمية" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "انطباعات أولى احترافية تليق بمستوى أعمالك وشركتك.", "خدمات الاستقبال" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "تعامل فعال ودقيق مع البريد الوارد والصادر لضمان سلاسة العمل.", "إدارة غرف البريد" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "ضمان سير المهام الإدارية اليومية بكفاءة وانسيابية تامة.", "إدارة المكاتب" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "طاقم أمني مدرب لحماية ممتلكاتك وتأمين منشأتك بفعالية.", "كوادر الحراسة والأمن" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "برامج إبادة آمنة وفعالة لضمان بيئة صحية ونظيفة.", "مكافحة الآفات" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "حلول مستدامة وآمنة للتخلص من النفايات وإعادة التدوير.", "إدارة النفايات وإعادة التدوير" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Services",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "DescriptionEn",
                table: "Services",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DescriptionAr", "TitleAr" },
                values: new object[] { "", "" });
        }
    }
}
