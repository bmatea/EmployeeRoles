using Microsoft.EntityFrameworkCore.Migrations;

namespace zadatak.Migrations
{
    public partial class EditEmployeeImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageUrl",
                value: "avatar1.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2,
                column: "ImageUrl",
                value: "avatar2.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3,
                column: "ImageUrl",
                value: "avatar3.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 4,
                column: "ImageUrl",
                value: "avatar4.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 5,
                column: "ImageUrl",
                value: "avatar5.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 6,
                column: "ImageUrl",
                value: "avatar6.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 7,
                column: "ImageUrl",
                value: "avatar7.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 8,
                column: "ImageUrl",
                value: "avatar8.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageUrl",
                value: "avatar1");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2,
                column: "ImageUrl",
                value: "avatar2");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3,
                column: "ImageUrl",
                value: "avatar3");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 4,
                column: "ImageUrl",
                value: "avatar4");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 5,
                column: "ImageUrl",
                value: "avatar5");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 6,
                column: "ImageUrl",
                value: "avatar6");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 7,
                column: "ImageUrl",
                value: "avatar7");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 8,
                column: "ImageUrl",
                value: "avatar8");
        }
    }
}
