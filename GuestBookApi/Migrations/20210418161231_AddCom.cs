using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBookApi.Migrations
{
    public partial class AddCom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coment",
                table: "GuestNotes",
                newName: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "GuestNotes",
                newName: "Coment");
        }
    }
}
