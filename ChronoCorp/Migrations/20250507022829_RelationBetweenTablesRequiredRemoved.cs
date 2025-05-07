using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChronoCorp.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenTablesRequiredRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Quart_Type_Quart_TypeQuartId",
                table: "Cedule_Quart");

            migrationBuilder.DropIndex(
                name: "IX_Cedule_Quart_TypeQuartId",
                table: "Cedule_Quart");

            migrationBuilder.DropColumn(
                name: "TypeQuartId",
                table: "Cedule_Quart");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_TypeQuart",
                table: "Cedule_Quart",
                column: "TypeQuart");

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Quart_Type_Quart_TypeQuart",
                table: "Cedule_Quart",
                column: "TypeQuart",
                principalTable: "Type_Quart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Quart_Type_Quart_TypeQuart",
                table: "Cedule_Quart");

            migrationBuilder.DropIndex(
                name: "IX_Cedule_Quart_TypeQuart",
                table: "Cedule_Quart");

            migrationBuilder.AddColumn<int>(
                name: "TypeQuartId",
                table: "Cedule_Quart",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_TypeQuartId",
                table: "Cedule_Quart",
                column: "TypeQuartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Quart_Type_Quart_TypeQuartId",
                table: "Cedule_Quart",
                column: "TypeQuartId",
                principalTable: "Type_Quart",
                principalColumn: "Id");
        }
    }
}
