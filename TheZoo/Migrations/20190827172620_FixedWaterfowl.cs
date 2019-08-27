using Microsoft.EntityFrameworkCore.Migrations;

namespace TheZoo.Migrations
{
    public partial class FixedWaterfowl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "WaterFowlGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "WaterFowlGroup",
                nullable: false,
                defaultValue: 0);
        }
    }
}
