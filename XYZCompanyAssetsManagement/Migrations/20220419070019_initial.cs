using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XYZCompanyAssetsManagement.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetsDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetsMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfReturn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    AssetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetsMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetsMapping_AssetsDetails_AssetsId",
                        column: x => x.AssetsId,
                        principalTable: "AssetsDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetsMapping_EmpDetails_EmpId",
                        column: x => x.EmpId,
                        principalTable: "EmpDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetsMapping_AssetsId",
                table: "AssetsMapping",
                column: "AssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetsMapping_EmpId",
                table: "AssetsMapping",
                column: "EmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetsMapping");

            migrationBuilder.DropTable(
                name: "AssetsDetails");

            migrationBuilder.DropTable(
                name: "EmpDetails");
        }
    }
}
