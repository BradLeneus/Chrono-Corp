using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChronoCorp.Migrations
{
    /// <inheritdoc />
    public partial class TestPrimaryKeyAndRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeQuart",
                table: "TypeQuart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FichePaie",
                table: "FichePaie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeCredentials",
                table: "EmployeeCredentials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DemandeConge",
                table: "DemandeConge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CeduleQuart",
                table: "CeduleQuart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CedulePointage",
                table: "CedulePointage");

            migrationBuilder.DropColumn(
                name: "IdEmployee",
                table: "EmployeeCredentials");

            migrationBuilder.RenameTable(
                name: "TypeQuart",
                newName: "Type_Quart");

            migrationBuilder.RenameTable(
                name: "FichePaie",
                newName: "Fiche_Paie");

            migrationBuilder.RenameTable(
                name: "EmployeeCredentials",
                newName: "Employee_Credentials");

            migrationBuilder.RenameTable(
                name: "DemandeConge",
                newName: "Demande_Conge");

            migrationBuilder.RenameTable(
                name: "CeduleQuart",
                newName: "Cedule_Quart");

            migrationBuilder.RenameTable(
                name: "CedulePointage",
                newName: "Cedule_Pointage");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Employee_Credentials",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Type_Quart",
                table: "Type_Quart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fiche_Paie",
                table: "Fiche_Paie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_Credentials",
                table: "Employee_Credentials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Demande_Conge",
                table: "Demande_Conge",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cedule_Quart",
                table: "Cedule_Quart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cedule_Pointage",
                table: "Cedule_Pointage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Credentials_Employee_Id",
                table: "Employee_Credentials",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Credentials_Employee_Id",
                table: "Employee_Credentials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Type_Quart",
                table: "Type_Quart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fiche_Paie",
                table: "Fiche_Paie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_Credentials",
                table: "Employee_Credentials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Demande_Conge",
                table: "Demande_Conge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cedule_Quart",
                table: "Cedule_Quart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cedule_Pointage",
                table: "Cedule_Pointage");

            migrationBuilder.RenameTable(
                name: "Type_Quart",
                newName: "TypeQuart");

            migrationBuilder.RenameTable(
                name: "Fiche_Paie",
                newName: "FichePaie");

            migrationBuilder.RenameTable(
                name: "Employee_Credentials",
                newName: "EmployeeCredentials");

            migrationBuilder.RenameTable(
                name: "Demande_Conge",
                newName: "DemandeConge");

            migrationBuilder.RenameTable(
                name: "Cedule_Quart",
                newName: "CeduleQuart");

            migrationBuilder.RenameTable(
                name: "Cedule_Pointage",
                newName: "CedulePointage");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "EmployeeCredentials",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<long>(
                name: "IdEmployee",
                table: "EmployeeCredentials",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeQuart",
                table: "TypeQuart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FichePaie",
                table: "FichePaie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeCredentials",
                table: "EmployeeCredentials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DemandeConge",
                table: "DemandeConge",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CeduleQuart",
                table: "CeduleQuart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CedulePointage",
                table: "CedulePointage",
                column: "Id");
        }
    }
}
