using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XYZCompanyAssetsManagement.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetsMapping_AssetsDetails_AssetsId",
                table: "AssetsMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetsMapping_EmpDetails_EmpId",
                table: "AssetsMapping");

            migrationBuilder.DropIndex(
                name: "IX_AssetsMapping_AssetsId",
                table: "AssetsMapping");

            migrationBuilder.DropIndex(
                name: "IX_AssetsMapping_EmpId",
                table: "AssetsMapping");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfReturn",
                table: "AssetsMapping",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "IdentifyNo",
                table: "AssetsDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentifyNo",
                table: "AssetsDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfReturn",
                table: "AssetsMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssetsMapping_AssetsId",
                table: "AssetsMapping",
                column: "AssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetsMapping_EmpId",
                table: "AssetsMapping",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetsMapping_AssetsDetails_AssetsId",
                table: "AssetsMapping",
                column: "AssetsId",
                principalTable: "AssetsDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetsMapping_EmpDetails_EmpId",
                table: "AssetsMapping",
                column: "EmpId",
                principalTable: "EmpDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
