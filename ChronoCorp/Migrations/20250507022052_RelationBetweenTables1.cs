using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChronoCorp.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPause",
                table: "Cedule_Pointage");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Type_Quart",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<long>(
                name: "IdSuperieur",
                table: "Employee",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeQuartId",
                table: "Cedule_Quart",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messagerie_IdDestinataire",
                table: "Messagerie",
                column: "IdDestinataire");

            migrationBuilder.CreateIndex(
                name: "IX_Messagerie_IdEmetteur",
                table: "Messagerie",
                column: "IdEmetteur");

            migrationBuilder.CreateIndex(
                name: "IX_Fiche_Paie_IdEmployee",
                table: "Fiche_Paie",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_IdSuperieur",
                table: "Employee",
                column: "IdSuperieur");

            migrationBuilder.CreateIndex(
                name: "IX_Demande_Conge_IdDestinataire",
                table: "Demande_Conge",
                column: "IdDestinataire");

            migrationBuilder.CreateIndex(
                name: "IX_Demande_Conge_IdEmetteur",
                table: "Demande_Conge",
                column: "IdEmetteur");

            migrationBuilder.CreateIndex(
                name: "IX_Demande_Conge_TypeQuart",
                table: "Demande_Conge",
                column: "TypeQuart");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_IdCreateur",
                table: "Cedule_Quart",
                column: "IdCreateur");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_IdEmployee",
                table: "Cedule_Quart",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_TypeQuartId",
                table: "Cedule_Quart",
                column: "TypeQuartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Pointage_IdEmployee",
                table: "Cedule_Pointage",
                column: "IdEmployee");

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Pointage_Employee_IdEmployee",
                table: "Cedule_Pointage",
                column: "IdEmployee",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Quart_Employee_IdCreateur",
                table: "Cedule_Quart",
                column: "IdCreateur",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Quart_Employee_IdEmployee",
                table: "Cedule_Quart",
                column: "IdEmployee",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cedule_Quart_Type_Quart_TypeQuartId",
                table: "Cedule_Quart",
                column: "TypeQuartId",
                principalTable: "Type_Quart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Demande_Conge_Employee_IdDestinataire",
                table: "Demande_Conge",
                column: "IdDestinataire",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Demande_Conge_Employee_IdEmetteur",
                table: "Demande_Conge",
                column: "IdEmetteur",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Demande_Conge_Type_Quart_TypeQuart",
                table: "Demande_Conge",
                column: "TypeQuart",
                principalTable: "Type_Quart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_IdSuperieur",
                table: "Employee",
                column: "IdSuperieur",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fiche_Paie_Employee_IdEmployee",
                table: "Fiche_Paie",
                column: "IdEmployee",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messagerie_Employee_IdDestinataire",
                table: "Messagerie",
                column: "IdDestinataire",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messagerie_Employee_IdEmetteur",
                table: "Messagerie",
                column: "IdEmetteur",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Pointage_Employee_IdEmployee",
                table: "Cedule_Pointage");

            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Quart_Employee_IdCreateur",
                table: "Cedule_Quart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Quart_Employee_IdEmployee",
                table: "Cedule_Quart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cedule_Quart_Type_Quart_TypeQuartId",
                table: "Cedule_Quart");

            migrationBuilder.DropForeignKey(
                name: "FK_Demande_Conge_Employee_IdDestinataire",
                table: "Demande_Conge");

            migrationBuilder.DropForeignKey(
                name: "FK_Demande_Conge_Employee_IdEmetteur",
                table: "Demande_Conge");

            migrationBuilder.DropForeignKey(
                name: "FK_Demande_Conge_Type_Quart_TypeQuart",
                table: "Demande_Conge");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_IdSuperieur",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Fiche_Paie_Employee_IdEmployee",
                table: "Fiche_Paie");

            migrationBuilder.DropForeignKey(
                name: "FK_Messagerie_Employee_IdDestinataire",
                table: "Messagerie");

            migrationBuilder.DropForeignKey(
                name: "FK_Messagerie_Employee_IdEmetteur",
                table: "Messagerie");

            migrationBuilder.DropIndex(
                name: "IX_Messagerie_IdDestinataire",
                table: "Messagerie");

            migrationBuilder.DropIndex(
                name: "IX_Messagerie_IdEmetteur",
                table: "Messagerie");

            migrationBuilder.DropIndex(
                name: "IX_Fiche_Paie_IdEmployee",
                table: "Fiche_Paie");

            migrationBuilder.DropIndex(
                name: "IX_Employee_IdSuperieur",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Demande_Conge_IdDestinataire",
                table: "Demande_Conge");

            migrationBuilder.DropIndex(
                name: "IX_Demande_Conge_IdEmetteur",
                table: "Demande_Conge");

            migrationBuilder.DropIndex(
                name: "IX_Demande_Conge_TypeQuart",
                table: "Demande_Conge");

            migrationBuilder.DropIndex(
                name: "IX_Cedule_Quart_IdCreateur",
                table: "Cedule_Quart");

            migrationBuilder.DropIndex(
                name: "IX_Cedule_Quart_IdEmployee",
                table: "Cedule_Quart");

            migrationBuilder.DropIndex(
                name: "IX_Cedule_Quart_TypeQuartId",
                table: "Cedule_Quart");

            migrationBuilder.DropIndex(
                name: "IX_Cedule_Pointage_IdEmployee",
                table: "Cedule_Pointage");

            migrationBuilder.DropColumn(
                name: "TypeQuartId",
                table: "Cedule_Quart");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Type_Quart",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "IdSuperieur",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPause",
                table: "Cedule_Pointage",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
