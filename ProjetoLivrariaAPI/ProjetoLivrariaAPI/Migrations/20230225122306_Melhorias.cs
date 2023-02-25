using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivrariaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Melhorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro");

            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Editora_EditoraId",
                table: "Livro");

            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Genero_GeneroId",
                table: "Livro");

            migrationBuilder.DropTable(
                name: "Editora");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro");

            migrationBuilder.DropIndex(
                name: "IX_Livro_GeneroId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "EditoraId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Livro");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFotoCapa",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorId",
                table: "Livro",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Editora",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "AutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Editora",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Livro");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFotoCapa",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorId",
                table: "Livro",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EditoraId",
                table: "Livro",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GeneroId",
                table: "Livro",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Editora",
                columns: table => new
                {
                    EditoraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditoraNome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editora", x => x.EditoraId);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GeneroId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro",
                column: "EditoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_GeneroId",
                table: "Livro",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "AutorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Editora_EditoraId",
                table: "Livro",
                column: "EditoraId",
                principalTable: "Editora",
                principalColumn: "EditoraId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Genero_GeneroId",
                table: "Livro",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "GeneroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
