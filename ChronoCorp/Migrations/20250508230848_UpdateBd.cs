using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChronoCorp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdSuperieur = table.Column<long>(type: "bigint", nullable: true),
                    Prenom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Courriel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdresseLigne1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdresseLigne2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ville = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodePostal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telephone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateNaissance = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ContactUrgenceTel = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactUrgenceNom = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateEmbauche = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Departement = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Poste = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Salaire = table.Column<float>(type: "float", nullable: false),
                    EstActif = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ArgentGagneTotal = table.Column<float>(type: "float", nullable: true),
                    NbrHeureTotal = table.Column<float>(type: "float", nullable: true),
                    NbrHeureConge = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Employee_IdSuperieur",
                        column: x => x.IdSuperieur,
                        principalTable: "Employee",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Type_Quart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstConge = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TauxMajoration = table.Column<float>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Quart", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employee_Credentials",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Mdp = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Credentials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Credentials_Employee_Id",
                        column: x => x.Id,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fiche_Paie",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmployee = table.Column<long>(type: "bigint", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Montant = table.Column<float>(type: "float", nullable: false),
                    NbrHeure = table.Column<float>(type: "float", nullable: false),
                    VacanceCumul = table.Column<float>(type: "float", nullable: false),
                    DatePaie = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiche_Paie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fiche_Paie_Employee_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Messagerie",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmetteur = table.Column<long>(type: "bigint", nullable: false),
                    IdDestinataire = table.Column<long>(type: "bigint", nullable: false),
                    TypeMessage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contenu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Temps = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messagerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messagerie_Employee_IdDestinataire",
                        column: x => x.IdDestinataire,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messagerie_Employee_IdEmetteur",
                        column: x => x.IdEmetteur,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cedule_Quart",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmployee = table.Column<long>(type: "bigint", nullable: false),
                    IdCreateur = table.Column<long>(type: "bigint", nullable: false),
                    TypeQuart = table.Column<int>(type: "int", nullable: false),
                    IsPausePayee = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HeureDebut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HeureFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HeureEntree = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    HeureDepart = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsPointageApprouve = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cedule_Quart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cedule_Quart_Employee_IdCreateur",
                        column: x => x.IdCreateur,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cedule_Quart_Employee_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cedule_Quart_Type_Quart_TypeQuart",
                        column: x => x.TypeQuart,
                        principalTable: "Type_Quart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Demande_Conge",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmetteur = table.Column<long>(type: "bigint", nullable: false),
                    IdDestinataire = table.Column<long>(type: "bigint", nullable: false),
                    TempsSoumission = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TypeQuart = table.Column<int>(type: "int", nullable: false),
                    Commentaire = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reponse = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstApprouve = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TempsModif = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demande_Conge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demande_Conge_Employee_IdDestinataire",
                        column: x => x.IdDestinataire,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Demande_Conge_Employee_IdEmetteur",
                        column: x => x.IdEmetteur,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Demande_Conge_Type_Quart_TypeQuart",
                        column: x => x.TypeQuart,
                        principalTable: "Type_Quart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_IdCreateur",
                table: "Cedule_Quart",
                column: "IdCreateur");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_IdEmployee",
                table: "Cedule_Quart",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Cedule_Quart_TypeQuart",
                table: "Cedule_Quart",
                column: "TypeQuart");

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
                name: "IX_Employee_IdSuperieur",
                table: "Employee",
                column: "IdSuperieur");

            migrationBuilder.CreateIndex(
                name: "IX_Fiche_Paie_IdEmployee",
                table: "Fiche_Paie",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Messagerie_IdDestinataire",
                table: "Messagerie",
                column: "IdDestinataire");

            migrationBuilder.CreateIndex(
                name: "IX_Messagerie_IdEmetteur",
                table: "Messagerie",
                column: "IdEmetteur");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cedule_Quart");

            migrationBuilder.DropTable(
                name: "Demande_Conge");

            migrationBuilder.DropTable(
                name: "Employee_Credentials");

            migrationBuilder.DropTable(
                name: "Fiche_Paie");

            migrationBuilder.DropTable(
                name: "Messagerie");

            migrationBuilder.DropTable(
                name: "Type_Quart");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
