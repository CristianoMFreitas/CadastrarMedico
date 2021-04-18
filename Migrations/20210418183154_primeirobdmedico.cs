using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastrarMedico.Migrations
{
    public partial class primeirobdmedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Especialidade = table.Column<string>(nullable: true),
                    Cooperador = table.Column<bool>(nullable: false),
                    UnidadeAtendimento = table.Column<string>(nullable: true),
                    AtendeSUS = table.Column<bool>(nullable: false),
                    FoiVisitado = table.Column<bool>(nullable: false),
                    TemKit = table.Column<bool>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    observacoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
