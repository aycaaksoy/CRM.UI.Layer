using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.DataAccess.Layer.Migrations
{
    public partial class add_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EmployeeStatus",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Employees");
        }
    }
}
