using Microsoft.EntityFrameworkCore.Migrations;

namespace miguel.Migrations
{
    public partial class Anotacoes_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueOrdens_Estoques_estoqueid",
                table: "EstoqueOrdens");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueOrdens_Ordens_ordemid",
                table: "EstoqueOrdens");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Custo_valorid",
                table: "Ordens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordens",
                table: "Ordens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstoqueOrdens",
                table: "EstoqueOrdens");

            migrationBuilder.DropColumn(
                name: "valor",
                table: "Custo");

            migrationBuilder.DropColumn(
                name: "rg",
                table: "Ordens");

            migrationBuilder.RenameTable(
                name: "Ordens",
                newName: "Ordem");

            migrationBuilder.RenameTable(
                name: "EstoqueOrdens",
                newName: "Insumo");

            migrationBuilder.RenameIndex(
                name: "IX_Ordens_valorid",
                table: "Ordem",
                newName: "IX_Ordem_valorid");

            migrationBuilder.RenameIndex(
                name: "IX_EstoqueOrdens_ordemid",
                table: "Insumo",
                newName: "IX_Insumo_ordemid");

            migrationBuilder.RenameIndex(
                name: "IX_EstoqueOrdens_estoqueid",
                table: "Insumo",
                newName: "IX_Insumo_estoqueid");

            migrationBuilder.AlterColumn<float>(
                name: "vfornecedor",
                table: "Custo",
                type: "real",
                maxLength: 35,
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "problema",
                table: "Custo",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "mobra",
                table: "Custo",
                type: "real",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "proprietario",
                table: "Ordem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "Ordem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "defeito",
                table: "Ordem",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Ordem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cpf",
                table: "Ordem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordem",
                table: "Ordem",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Insumo",
                table: "Insumo",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insumo_Estoques_estoqueid",
                table: "Insumo",
                column: "estoqueid",
                principalTable: "Estoques",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Insumo_Ordem_ordemid",
                table: "Insumo",
                column: "ordemid",
                principalTable: "Ordem",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordem_Custo_valorid",
                table: "Ordem",
                column: "valorid",
                principalTable: "Custo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insumo_Estoques_estoqueid",
                table: "Insumo");

            migrationBuilder.DropForeignKey(
                name: "FK_Insumo_Ordem_ordemid",
                table: "Insumo");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordem_Custo_valorid",
                table: "Ordem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordem",
                table: "Ordem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Insumo",
                table: "Insumo");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Ordem");

            migrationBuilder.RenameTable(
                name: "Ordem",
                newName: "Ordens");

            migrationBuilder.RenameTable(
                name: "Insumo",
                newName: "EstoqueOrdens");

            migrationBuilder.RenameIndex(
                name: "IX_Ordem_valorid",
                table: "Ordens",
                newName: "IX_Ordens_valorid");

            migrationBuilder.RenameIndex(
                name: "IX_Insumo_ordemid",
                table: "EstoqueOrdens",
                newName: "IX_EstoqueOrdens_ordemid");

            migrationBuilder.RenameIndex(
                name: "IX_Insumo_estoqueid",
                table: "EstoqueOrdens",
                newName: "IX_EstoqueOrdens_estoqueid");

            migrationBuilder.AlterColumn<string>(
                name: "vfornecedor",
                table: "Custo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "problema",
                table: "Custo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<int>(
                name: "mobra",
                table: "Custo",
                type: "int",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldMaxLength: 35);

            migrationBuilder.AddColumn<int>(
                name: "valor",
                table: "Custo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "proprietario",
                table: "Ordens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "Ordens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "defeito",
                table: "Ordens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Ordens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "rg",
                table: "Ordens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordens",
                table: "Ordens",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstoqueOrdens",
                table: "EstoqueOrdens",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueOrdens_Estoques_estoqueid",
                table: "EstoqueOrdens",
                column: "estoqueid",
                principalTable: "Estoques",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueOrdens_Ordens_ordemid",
                table: "EstoqueOrdens",
                column: "ordemid",
                principalTable: "Ordens",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Custo_valorid",
                table: "Ordens",
                column: "valorid",
                principalTable: "Custo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
