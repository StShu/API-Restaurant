using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class added_new_settings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Menues_MenuId",
                table: "Dishes");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Dishes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Menues_MenuId",
                table: "Dishes",
                column: "MenuId",
                principalTable: "Menues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Menues_MenuId",
                table: "Dishes");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Dishes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Menues_MenuId",
                table: "Dishes",
                column: "MenuId",
                principalTable: "Menues",
                principalColumn: "Id");
        }
    }
}
