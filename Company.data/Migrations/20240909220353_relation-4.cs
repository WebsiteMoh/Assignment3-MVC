using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.data.Migrations
{
    public partial class relation4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_departmentID",
                table: "Employees");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentID",
                table: "Employees",
                column: "departmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_departmentID",
                table: "Employees",
                column: "departmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
