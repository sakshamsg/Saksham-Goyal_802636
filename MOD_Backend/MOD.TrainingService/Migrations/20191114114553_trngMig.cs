using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class trngMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_id = table.Column<string>(nullable: true),
                    Tech_id = table.Column<string>(nullable: true),
                    Mentor_id = table.Column<string>(nullable: true),
                    Timeslot = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Progress = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Training");
        }
    }
}
