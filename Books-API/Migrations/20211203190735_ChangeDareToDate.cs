using Microsoft.EntityFrameworkCore.Migrations;

namespace Books_API.Migrations
{
    public partial class ChangeDareToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DareRead",
                table: "Books",
                newName: "DateRead");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRead",
                table: "Books",
                newName: "DareRead");
        }
    }
}
