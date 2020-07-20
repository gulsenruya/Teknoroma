using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class _20072020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserAdresses_UserAdressID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserAdressID",
                table: "Orders",
                newName: "UserAdressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserAdressID",
                table: "Orders",
                newName: "IX_Orders_UserAdressId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserAdressId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserAdresses_UserAdressId",
                table: "Orders",
                column: "UserAdressId",
                principalTable: "UserAdresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserAdresses_UserAdressId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserAdressId",
                table: "Orders",
                newName: "UserAdressID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserAdressId",
                table: "Orders",
                newName: "IX_Orders_UserAdressID");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserAdressID",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "AdressId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserAdresses_UserAdressID",
                table: "Orders",
                column: "UserAdressID",
                principalTable: "UserAdresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
