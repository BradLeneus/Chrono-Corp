using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChronoCorp.Migrations
{
    /// <inheritdoc />
    public partial class MajCeduleQuart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Pointage_Employee_IdEmployee",
                table: "Cedule_Pointage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cedule_Pointage",
                table: "Cedule_Pointage");

            migrationBuilder.RenameTable(
                name: "Cedule_Pointage",
                newName: "CedulePointage");

            migrationBuilder.RenameIndex(
                name: "IX_Cedule_Pointage_IdEmployee",
                table: "CedulePointage",
                newName: "IX_CedulePointage_IdEmployee");

            migrationBuilder.AddColumn<DateTime>(
                name: "HeureDepart",
                table: "Cedule_Quart",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HeureEntree",
                table: "Cedule_Quart",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPausePayee",
                table: "Cedule_Quart",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CedulePointage",
                table: "CedulePointage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CedulePointage_Employee_IdEmployee",
                table: "CedulePointage",
                column: "IdEmployee",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CedulePointage_Employee_IdEmployee",
                table: "CedulePointage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CedulePointage",
                table: "CedulePointage");

            migrationBuilder.DropColumn(
                name: "HeureDepart",
                table: "Cedule_Quart");

            migrationBuilder.DropColumn(
                name: "HeureEntree",
                table: "Cedule_Quart");

            migrationBuilder.DropColumn(
                name: "IsPausePayee",
                table: "Cedule_Quart");

            migrationBuilder.RenameTable(
                name: "CedulePointage",
                newName: "Cedule_Pointage");

            migrationBuilder.RenameIndex(
                name: "IX_CedulePointage_IdEmployee",
                table: "Cedule_Pointage",
                newName: "IX_Cedule_Pointage_IdEmployee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cedule_Pointage",
                table: "Cedule_Pointage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Pointage_Employee_IdEmployee",
                table: "Cedule_Pointage",
                column: "IdEmployee",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
