using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp_travel_agency.Migrations
{
    public partial class AddProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Packages");
        }
    }
}
