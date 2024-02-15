using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class addedNewPropertyMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Menues",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Menues",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Menues");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Menues");
        }
    }
}
