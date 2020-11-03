using Microsoft.EntityFrameworkCore.Migrations;

namespace zadatak.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => new { x.EmployeeId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "Email", "FullName", "ImageUrl", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "frank.luna@mail.com", "Frank Luna", "avatar1", "789-777-356" },
                    { 2, "tomas.moller@mail.com", "Tomas Moller", "avatar2", "466-222-333" },
                    { 3, "eric.haines@mail.com", "Eric Haines", "avatar3", "888-999-234" },
                    { 4, "thomas.cormen@mail.com", "Thomas E. Cormen", "avatar4", "567-222-465" },
                    { 5, "count.saint.germain@mail.com", "Count Saint Germain", "avatar5", "737-922-495" },
                    { 6, "franz.mesmer@mail.com", "Franz Mesmer", "avatar6", "837-555-133" },
                    { 7, "erzsebet.bathory@mail.com", "Erzsebet Bathory", "avatar7", "666-666-666" },
                    { 8, "mislav.mihajlovic@mail.com", "Mislav Mihajlovic", "avatar8", "123-321-456" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeRoles",
                columns: new[] { "EmployeeId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 7, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 5, 2 },
                    { 8, 2 },
                    { 4, 3 },
                    { 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoles_RoleId",
                table: "EmployeeRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
