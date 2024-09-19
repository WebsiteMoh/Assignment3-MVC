using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.data.Migrations
{
    public partial class add7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }
    }
}
