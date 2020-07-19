using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class OrderUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AdressId",
                table: "Orders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserAdressID",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserAdressID",
                table: "Orders",
                column: "UserAdressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserAdresses_UserAdressID",
                table: "Orders",
                column: "UserAdressID",
                principalTable: "UserAdresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserAdresses_UserAdressID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserAdressID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserAdressID",
                table: "Orders");
        }
    }
}
