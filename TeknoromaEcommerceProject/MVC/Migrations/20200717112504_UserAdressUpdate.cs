using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class UserAdressUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdressName",
                table: "UserAdresses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TCNo",
                table: "UserAdresses",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressName",
                table: "UserAdresses");

            migrationBuilder.DropColumn(
                name: "TCNo",
                table: "UserAdresses");
        }
    }
}
