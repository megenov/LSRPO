using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LSRPO.Infrastructure.Migrations
{
    public partial class AddUserDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "USR_DESC",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USR_DESC",
                table: "AspNetUsers");
        }
    }
}
