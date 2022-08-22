using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mundial2022.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AJUSTES_PUNTAJE",
                columns: table => new
                {
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    A_PUNTAJE_VICTORIA = table.Column<int>(type: "int", nullable: true),
                    A_PUNTAJE_EMPATE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AJUSTES___71AC6D41E5C82299", x => x.A_ID);
                });

            migrationBuilder.CreateTable(
                name: "CAMPEONATO",
                columns: table => new
                {
                    C_CAMPEONATO = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    N_CAMPEONATO = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    Q_PARTIDOS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CAMPEONA__0F26C2A815FF9A47", x => x.C_CAMPEONATO);
                });

            migrationBuilder.CreateTable(
                name: "EQUIPO",
                columns: table => new
                {
                    C_EQUIPO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    N_EQUIPO = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    E_NOMBRE = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EQUIPO__93A80846780A110A", x => x.C_EQUIPO);
                });

            migrationBuilder.CreateTable(
                name: "ESTADIO",
                columns: table => new
                {
                    C_ESTADIO = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    N_ESTADIO = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ESTADIO__45173E5BDD30A711", x => x.C_ESTADIO);
                });

            migrationBuilder.CreateTable(
                name: "JUGADOR",
                columns: table => new
                {
                    C_JUGADOR = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    N_JUGADOR = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    D_NACIMIENTO = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JUGADOR__D7CD63001DBBF6CA", x => x.C_JUGADOR);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    U_CODIGO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    U_NOMBRE = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    U_APELLIDO = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    U_CORREO = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    U_PASSWORD = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    U_PUNTOS_TOTALES = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USUARIOS__E9817A8388322270", x => x.U_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "EQUIPOS_CAMPEONATO",
                columns: table => new
                {
                    E_C_ID = table.Column<int>(type: "int", nullable: false),
                    C_EQUIPO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    C_CAMPEONATO = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    E_TOTAL_PUNTOS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EQUIPOS___B5F0BEEFDCC47046", x => new { x.E_C_ID, x.C_EQUIPO, x.C_CAMPEONATO });
                    table.ForeignKey(
                        name: "FK__EQUIPOS_C__C_CAM__398D8EEE",
                        column: x => x.C_CAMPEONATO,
                        principalTable: "CAMPEONATO",
                        principalColumn: "C_CAMPEONATO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__EQUIPOS_C__C_EQU__3A81B327",
                        column: x => x.C_EQUIPO,
                        principalTable: "EQUIPO",
                        principalColumn: "C_EQUIPO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PARTIDO",
                columns: table => new
                {
                    NRO_PARTIDO = table.Column<int>(type: "int", nullable: false),
                    C_ESTADIO_PART = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    C_EQUIPO_1 = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    C_EQUIPO_2 = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    C_CAMPEONATO = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    D_PARTIDO = table.Column<DateTime>(type: "date", nullable: true),
                    N_JUEZ_LINEA1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    N_JUEZ_LINEA2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Q_GOLES_E1 = table.Column<int>(type: "int", nullable: true),
                    Q_GOLES_E2 = table.Column<int>(type: "int", nullable: true),
                    N_ARBITRO = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    E_PARTIDO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PARTIDO__9D531F53021D8BA8", x => x.NRO_PARTIDO);
                    table.ForeignKey(
                        name: "FK__PARTIDO__C_CAMPE__403A8C7D",
                        column: x => x.C_CAMPEONATO,
                        principalTable: "CAMPEONATO",
                        principalColumn: "C_CAMPEONATO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PARTIDO__C_EQUIP__412EB0B6",
                        column: x => x.C_EQUIPO_1,
                        principalTable: "EQUIPO",
                        principalColumn: "C_EQUIPO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PARTIDO__C_EQUIP__4222D4EF",
                        column: x => x.C_EQUIPO_2,
                        principalTable: "EQUIPO",
                        principalColumn: "C_EQUIPO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PARTIDO__C_ESTAD__4316F928",
                        column: x => x.C_ESTADIO_PART,
                        principalTable: "ESTADIO",
                        principalColumn: "C_ESTADIO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JUG_EQ_CAMP",
                columns: table => new
                {
                    C_JUGADOR = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    C_CAMPEONATO = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    C_EQUIPO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JUG_EQ_C__473F0F2A39F92F5D", x => new { x.C_JUGADOR, x.C_CAMPEONATO });
                    table.ForeignKey(
                        name: "FK__JUG_EQ_CA__C_CAM__3B75D760",
                        column: x => x.C_CAMPEONATO,
                        principalTable: "CAMPEONATO",
                        principalColumn: "C_CAMPEONATO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__JUG_EQ_CA__C_EQU__3C69FB99",
                        column: x => x.C_EQUIPO,
                        principalTable: "EQUIPO",
                        principalColumn: "C_EQUIPO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__JUG_EQ_CA__C_JUG__3D5E1FD2",
                        column: x => x.C_JUGADOR,
                        principalTable: "JUGADOR",
                        principalColumn: "C_JUGADOR",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APUESTAS_USUARIOS",
                columns: table => new
                {
                    NRO_APUETAS = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    NRO_PARTIDO = table.Column<int>(type: "int", nullable: false),
                    U_CODIGO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    A_TIPO_RESULTADO = table.Column<int>(type: "int", nullable: true),
                    A_RESULTADO_E1 = table.Column<int>(type: "int", nullable: true),
                    A_RESULTADO_E2 = table.Column<int>(type: "int", nullable: true),
                    A_PUNTOS_CANJEADOS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APUESTAS__EF7BBDE27E7DEF11", x => new { x.NRO_APUETAS, x.NRO_PARTIDO, x.U_CODIGO });
                    table.ForeignKey(
                        name: "FK__APUESTAS___NRO_P__37A5467C",
                        column: x => x.NRO_PARTIDO,
                        principalTable: "PARTIDO",
                        principalColumn: "NRO_PARTIDO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__APUESTAS___U_COD__38996AB5",
                        column: x => x.U_CODIGO,
                        principalTable: "USUARIOS",
                        principalColumn: "U_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JUG_PARTIDO",
                columns: table => new
                {
                    C_JUGADOR = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    NRO_PARTIDO = table.Column<int>(type: "int", nullable: false),
                    N_POSICION = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    NRO_CAMISETA = table.Column<int>(type: "int", nullable: false),
                    F_EXPULSADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    F_AMONESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    F_GOLEADOR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JUG_PART__FE1852F59CB83388", x => new { x.C_JUGADOR, x.NRO_PARTIDO });
                    table.ForeignKey(
                        name: "FK__JUG_PARTI__C_JUG__3E52440B",
                        column: x => x.C_JUGADOR,
                        principalTable: "JUGADOR",
                        principalColumn: "C_JUGADOR",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__JUG_PARTI__NRO_P__3F466844",
                        column: x => x.NRO_PARTIDO,
                        principalTable: "PARTIDO",
                        principalColumn: "NRO_PARTIDO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APUESTAS_USUARIOS_NRO_PARTIDO",
                table: "APUESTAS_USUARIOS",
                column: "NRO_PARTIDO");

            migrationBuilder.CreateIndex(
                name: "IX_APUESTAS_USUARIOS_U_CODIGO",
                table: "APUESTAS_USUARIOS",
                column: "U_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_EQUIPOS_CAMPEONATO_C_CAMPEONATO",
                table: "EQUIPOS_CAMPEONATO",
                column: "C_CAMPEONATO");

            migrationBuilder.CreateIndex(
                name: "IX_EQUIPOS_CAMPEONATO_C_EQUIPO",
                table: "EQUIPOS_CAMPEONATO",
                column: "C_EQUIPO");

            migrationBuilder.CreateIndex(
                name: "IX_JUG_EQ_CAMP_C_CAMPEONATO",
                table: "JUG_EQ_CAMP",
                column: "C_CAMPEONATO");

            migrationBuilder.CreateIndex(
                name: "IX_JUG_EQ_CAMP_C_EQUIPO",
                table: "JUG_EQ_CAMP",
                column: "C_EQUIPO");

            migrationBuilder.CreateIndex(
                name: "IX_JUG_PARTIDO_NRO_PARTIDO",
                table: "JUG_PARTIDO",
                column: "NRO_PARTIDO");

            migrationBuilder.CreateIndex(
                name: "IX_PARTIDO_C_CAMPEONATO",
                table: "PARTIDO",
                column: "C_CAMPEONATO");

            migrationBuilder.CreateIndex(
                name: "IX_PARTIDO_C_EQUIPO_1",
                table: "PARTIDO",
                column: "C_EQUIPO_1");

            migrationBuilder.CreateIndex(
                name: "IX_PARTIDO_C_EQUIPO_2",
                table: "PARTIDO",
                column: "C_EQUIPO_2");

            migrationBuilder.CreateIndex(
                name: "IX_PARTIDO_C_ESTADIO_PART",
                table: "PARTIDO",
                column: "C_ESTADIO_PART");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AJUSTES_PUNTAJE");

            migrationBuilder.DropTable(
                name: "APUESTAS_USUARIOS");

            migrationBuilder.DropTable(
                name: "EQUIPOS_CAMPEONATO");

            migrationBuilder.DropTable(
                name: "JUG_EQ_CAMP");

            migrationBuilder.DropTable(
                name: "JUG_PARTIDO");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "JUGADOR");

            migrationBuilder.DropTable(
                name: "PARTIDO");

            migrationBuilder.DropTable(
                name: "CAMPEONATO");

            migrationBuilder.DropTable(
                name: "EQUIPO");

            migrationBuilder.DropTable(
                name: "ESTADIO");
        }
    }
}
