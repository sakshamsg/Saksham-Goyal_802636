using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.UserService.Migrations
{
    public partial class userMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Student_PhoneNumber",
                table: "Student",
                newName: "ContactNumber");

            migrationBuilder.RenameColumn(
                name: "Student_Password",
                table: "Student",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Student_Name",
                table: "Student",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Student_EmailId",
                table: "Student",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Mentor_YrsOfExp",
                table: "Mentor",
                newName: "Experience");

            migrationBuilder.RenameColumn(
                name: "Mentor_Timeslot",
                table: "Mentor",
                newName: "Timeslot");

            migrationBuilder.RenameColumn(
                name: "Mentor_Skills",
                table: "Mentor",
                newName: "Skill");

            migrationBuilder.RenameColumn(
                name: "Mentor_PhoneNumber",
                table: "Mentor",
                newName: "ContactNumber");

            migrationBuilder.RenameColumn(
                name: "Mentor_Password",
                table: "Mentor",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Mentor_EmailId",
                table: "Mentor",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "MentorName",
                table: "Mentor",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Student",
                newName: "Student_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Student",
                newName: "Student_Password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "Student_Name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Student",
                newName: "Student_EmailId");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Mentor",
                newName: "Mentor_YrsOfExp");

            migrationBuilder.RenameColumn(
                name: "Timeslot",
                table: "Mentor",
                newName: "Mentor_Timeslot");

            migrationBuilder.RenameColumn(
                name: "Skill",
                table: "Mentor",
                newName: "Mentor_Skills");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Mentor",
                newName: "Mentor_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Mentor",
                newName: "Mentor_Password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Mentor",
                newName: "Mentor_EmailId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Mentor",
                newName: "MentorName");
        }
    }
}
