using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.AuthenticateService.Migrations
{
    public partial class authMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentors",
                table: "Mentors");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Mentors",
                newName: "Mentor");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mentor",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor",
                column: "MentorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Mentor",
                newName: "Mentors");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Students",
                newName: "Student_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Students",
                newName: "Student_Password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "Student_Name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Students",
                newName: "Student_EmailId");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Mentors",
                newName: "Mentor_YrsOfExp");

            migrationBuilder.RenameColumn(
                name: "Timeslot",
                table: "Mentors",
                newName: "Mentor_Timeslot");

            migrationBuilder.RenameColumn(
                name: "Skill",
                table: "Mentors",
                newName: "Mentor_Skills");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Mentors",
                newName: "Mentor_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Mentors",
                newName: "Mentor_Password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Mentors",
                newName: "Mentor_EmailId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Mentors",
                newName: "MentorName");

            migrationBuilder.AlterColumn<string>(
                name: "MentorName",
                table: "Mentors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentors",
                table: "Mentors",
                column: "MentorId");
        }
    }
}
