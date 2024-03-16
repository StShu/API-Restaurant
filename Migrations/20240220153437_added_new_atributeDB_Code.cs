using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class added_new_atributeDB_Code : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Restaurants",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Restaurants");
        }
    }
}
