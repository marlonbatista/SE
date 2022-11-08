using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace se_api.Migrations
{
    public partial class AtualizacaoResponsavel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responsaveis_Alunos_AlunoRegistro",
                table: "Responsaveis");

            migrationBuilder.DropIndex(
                name: "IX_Responsaveis_AlunoRegistro",
                table: "Responsaveis");

            migrationBuilder.DropColumn(
                name: "AlunoRegistro",
                table: "Responsaveis");

            migrationBuilder.AddColumn<int>(
                name: "CodTurma",
                table: "Matriculas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Responsaveis_RegistroAluno",
                table: "Responsaveis",
                column: "RegistroAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_CodTurma",
                table: "Matriculas",
                column: "CodTurma");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Turma_CodTurma",
                table: "Matriculas",
                column: "CodTurma",
                principalTable: "Turma",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsaveis_Alunos_RegistroAluno",
                table: "Responsaveis",
                column: "RegistroAluno",
                principalTable: "Alunos",
                principalColumn: "Registro",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Turma_CodTurma",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsaveis_Alunos_RegistroAluno",
                table: "Responsaveis");

            migrationBuilder.DropIndex(
                name: "IX_Responsaveis_RegistroAluno",
                table: "Responsaveis");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_CodTurma",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "CodTurma",
                table: "Matriculas");

            migrationBuilder.AddColumn<int>(
                name: "AlunoRegistro",
                table: "Responsaveis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Responsaveis_AlunoRegistro",
                table: "Responsaveis",
                column: "AlunoRegistro");

            migrationBuilder.AddForeignKey(
                name: "FK_Responsaveis_Alunos_AlunoRegistro",
                table: "Responsaveis",
                column: "AlunoRegistro",
                principalTable: "Alunos",
                principalColumn: "Registro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
