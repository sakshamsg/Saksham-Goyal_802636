using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.AuthenticateService.Migrations
{
    public partial class authMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    MentorId = table.Column<string>(nullable: false),
                    MentorName = table.Column<string>(nullable: true),
                    Mentor_EmailId = table.Column<string>(nullable: true),
                    Mentor_PhoneNumber = table.Column<int>(nullable: false),
                    Mentor_Password = table.Column<string>(nullable: true),
                    Mentor_YrsOfExp = table.Column<int>(nullable: false),
                    Mentor_Skills = table.Column<string>(nullable: true),
                    Mentor_Timeslot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.MentorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    Student_Name = table.Column<string>(maxLength: 30, nullable: true),
                    Student_EmailId = table.Column<string>(nullable: true),
                    Student_PhoneNumber = table.Column<int>(nullable: false),
                    Student_Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
