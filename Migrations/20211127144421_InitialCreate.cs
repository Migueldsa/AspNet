using Microsoft.EntityFrameworkCore.Migrations;

namespace miguel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mobra = table.Column<int>(type: "int", nullable: false),
                    vfornecedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<int>(type: "int", nullable: false),
                    dias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    problema = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantidade = table.Column<float>(type: "real", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ordens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proprietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    defeito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordens", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ordens_Custos_valorid",
                        column: x => x.valorid,
                        principalTable: "Custos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstoqueOrdens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ordemid = table.Column<int>(type: "int", nullable: true),
                    estoqueid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueOrdens", x => x.id);
                    table.ForeignKey(
                        name: "FK_EstoqueOrdens_Estoques_estoqueid",
                        column: x => x.estoqueid,
                        principalTable: "Estoques",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstoqueOrdens_Ordens_ordemid",
                        column: x => x.ordemid,
                        principalTable: "Ordens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueOrdens_estoqueid",
                table: "EstoqueOrdens",
                column: "estoqueid");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueOrdens_ordemid",
                table: "EstoqueOrdens",
                column: "ordemid");

            migrationBuilder.CreateIndex(
                name: "IX_Ordens_valorid",
                table: "Ordens",
                column: "valorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstoqueOrdens");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Ordens");

            migrationBuilder.DropTable(
                name: "Custos");
        }
    }
}
