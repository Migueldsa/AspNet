using Microsoft.EntityFrameworkCore.Migrations;

namespace miguel.Migrations
{
    public partial class Anotacoes_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Custos_valorid",
                table: "Ordens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Custos",
                table: "Custos");

            migrationBuilder.RenameTable(
                name: "Custos",
                newName: "Custo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Custo",
                table: "Custo",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Custo_valorid",
                table: "Ordens",
                column: "valorid",
                principalTable: "Custo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Custo_valorid",
                table: "Ordens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Custo",
                table: "Custo");

            migrationBuilder.RenameTable(
                name: "Custo",
                newName: "Custos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Custos",
                table: "Custos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Custos_valorid",
                table: "Ordens",
                column: "valorid",
                principalTable: "Custos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
