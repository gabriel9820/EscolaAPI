using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Nascimento = table.Column<string>(type: "TEXT", nullable: true),
                    ProfessorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Carlos da Silva" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Paula Souza" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Simone Santos" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nascimento", "Nome", "ProfessorId" },
                values: new object[] { 1, "01/01/2000", "Alex Marques", 1 });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nascimento", "Nome", "ProfessorId" },
                values: new object[] { 2, "01/02/2000", "Júlia Pereira", 2 });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nascimento", "Nome", "ProfessorId" },
                values: new object[] { 3, "01/03/2000", "Caio Ferreira", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ProfessorId",
                table: "Alunos",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
