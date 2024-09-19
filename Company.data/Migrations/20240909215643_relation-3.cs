using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.data.Migrations
{
    public partial class relation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentID",
                table: "Employees",
                column: "Dep_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_departmentID",
                table: "Employees",
                column: "Dep_ID",
                principalTable: "Department",
                principalColumn: "ID"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_departmentID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_departmentID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Dep_ID",
                table: "Employees");
        }
    }
}
