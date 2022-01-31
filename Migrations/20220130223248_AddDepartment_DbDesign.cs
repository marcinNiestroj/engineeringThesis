using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektInzynierskiBlazor.Migrations
{
    public partial class AddDepartment_DbDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Addres",
                table: "Locations",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Employees",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "Addres",
                table: "Employees",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "OfficeWorks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "OfficeWorks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEmployed",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Informations = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DepartmentId",
                table: "Orders",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeWorks_DepartmentId",
                table: "OfficeWorks",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeWorks_Departments_DepartmentId",
                table: "OfficeWorks",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Departments_DepartmentId",
                table: "Orders",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficeWorks_Departments_DepartmentId",
                table: "OfficeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Departments_DepartmentId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DepartmentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OfficeWorks_DepartmentId",
                table: "OfficeWorks");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "OfficeWorks");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "OfficeWorks");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsEmployed",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Locations",
                newName: "Addres");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Employees",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Addres");
        }
    }
}
