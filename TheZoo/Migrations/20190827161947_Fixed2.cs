using Microsoft.EntityFrameworkCore.Migrations;

namespace TheZoo.Migrations
{
    public partial class Fixed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "PettingZooAnimals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "PettingZooAnimals",
                nullable: false,
                defaultValue: 0);
        }
    }
}
