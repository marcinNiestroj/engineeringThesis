using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektInzynierskiBlazor.Migrations
{
    public partial class OrderEntitieChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Equipments_EquipmentId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "EquipmentId",
                table: "Orders",
                newName: "SecondEquipmentId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Orders",
                newName: "SecondEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_EquipmentId",
                table: "Orders",
                newName: "IX_Orders_SecondEquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                newName: "IX_Orders_SecondEmployeeId");

            migrationBuilder.AddColumn<string>(
                name: "FirstEmployeeId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstEquipmentId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FirstEmployeeId",
                table: "Orders",
                column: "FirstEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FirstEquipmentId",
                table: "Orders",
                column: "FirstEquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_FirstEmployeeId",
                table: "Orders",
                column: "FirstEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_SecondEmployeeId",
                table: "Orders",
                column: "SecondEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Equipments_FirstEquipmentId",
                table: "Orders",
                column: "FirstEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Equipments_SecondEquipmentId",
                table: "Orders",
                column: "SecondEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_FirstEmployeeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_SecondEmployeeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Equipments_FirstEquipmentId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Equipments_SecondEquipmentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FirstEmployeeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FirstEquipmentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstEmployeeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstEquipmentId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "SecondEquipmentId",
                table: "Orders",
                newName: "EquipmentId");

            migrationBuilder.RenameColumn(
                name: "SecondEmployeeId",
                table: "Orders",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_SecondEquipmentId",
                table: "Orders",
                newName: "IX_Orders_EquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_SecondEmployeeId",
                table: "Orders",
                newName: "IX_Orders_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                table: "Orders",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Equipments_EquipmentId",
                table: "Orders",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
