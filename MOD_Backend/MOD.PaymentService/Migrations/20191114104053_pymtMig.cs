using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.PaymentService.Migrations
{
    public partial class pymtMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_ID = table.Column<string>(maxLength: 30, nullable: true),
                    Amount = table.Column<double>(maxLength: 30, nullable: false),
                    M_ID = table.Column<string>(nullable: true),
                    MtrAmount = table.Column<double>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
