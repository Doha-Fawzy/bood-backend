using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bood.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddArabicFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Services",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleAr",
                table: "Services",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "TitleAr",
                table: "Services");
        }
    }
}
