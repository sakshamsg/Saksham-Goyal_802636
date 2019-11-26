using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class trngMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tech_id",
                table: "Training");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Training",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Training");

            migrationBuilder.AddColumn<string>(
                name: "Tech_id",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
