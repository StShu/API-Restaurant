using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class add_attr_imgSrc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgsrc",
                table: "Dishes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgsrc",
                table: "Dishes");
        }
    }
}
