using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastrodeTransacao.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaTransacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PessoaTransacao",
                columns: table => new
                {
                    IdTransacao = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPessoa = table.Column<int>(type: "INTEGER", nullable: false),
                    Despesa = table.Column<int>(type: "INTEGER", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Receita = table.Column<int>(type: "INTEGER", nullable: false),
                    Saldo = table.Column<int>(type: "INTEGER", nullable: false),
                    TransacaoDescricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaTransacao", x => new { x.IdTransacao, x.IdPessoa });
                });
        }
    }
}
