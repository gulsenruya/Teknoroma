using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class UserAdressUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserAdressID",
                table: "UserAdresses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAdresses_UserAdressID",
                table: "UserAdresses",
                column: "UserAdressID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAdresses_UserAdresses_UserAdressID",
                table: "UserAdresses",
                column: "UserAdressID",
                principalTable: "UserAdresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAdresses_UserAdresses_UserAdressID",
                table: "UserAdresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAdresses_UserAdressID",
                table: "UserAdresses");

            migrationBuilder.DropColumn(
                name: "UserAdressID",
                table: "UserAdresses");
        }
    }
}
