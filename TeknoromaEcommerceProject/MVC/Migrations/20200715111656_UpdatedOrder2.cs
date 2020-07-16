﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class UpdatedOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ShipperID",
                table: "Orders",
                newName: "ShipperId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders",
                newName: "IX_Orders_ShipperId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShipperId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ShipperId",
                table: "Orders",
                newName: "ShipperID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders",
                newName: "IX_Orders_ShipperID");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShipperID",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperID",
                table: "Orders",
                column: "ShipperID",
                principalTable: "Shippers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
