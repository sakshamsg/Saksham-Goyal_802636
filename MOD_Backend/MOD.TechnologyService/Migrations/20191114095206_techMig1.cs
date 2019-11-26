using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TechnologyService.Migrations
{
    public partial class techMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Technology");

            migrationBuilder.RenameColumn(
                name: "Tech_id",
                table: "Technology",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technology",
                table: "Technology",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Technology",
                table: "Technology");

            migrationBuilder.RenameTable(
                name: "Technology",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Employee",
                newName: "Tech_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Tech_id");
        }
    }
}
