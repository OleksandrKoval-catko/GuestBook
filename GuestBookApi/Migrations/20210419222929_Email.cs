using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBookApi.Migrations
{
    public partial class Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "GuestNotes",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "GuestNotes",
                newName: "Mail");
        }
    }
}
