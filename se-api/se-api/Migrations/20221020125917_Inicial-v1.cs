using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace se_api.Migrations
{
    public partial class Inicialv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lougradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Periodos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codPeriodo = table.Column<int>(type: "int", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false),
                    codSerie = table.Column<int>(type: "int", nullable: false),
                    SerieCodigo = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Turma_Periodos_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "Periodos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turma_Series_SerieCodigo",
                        column: x => x.SerieCodigo,
                        principalTable: "Series",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    localNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodEndereco = table.Column<int>(type: "int", nullable: false),
                    TurmaCodigo = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Registro);
                    table.ForeignKey(
                        name: "FK_Alunos_Enderecos_CodEndereco",
                        column: x => x.CodEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alunos_Turma_TurmaCodigo",
                        column: x => x.TurmaCodigo,
                        principalTable: "Turma",
                        principalColumn: "Codigo");
                });

            migrationBuilder.CreateTable(
                name: "Boletins",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroAluno = table.Column<int>(type: "int", nullable: false),
                    AlunoRegistro = table.Column<int>(type: "int", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletins", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Boletins_Alunos_AlunoRegistro",
                        column: x => x.AlunoRegistro,
                        principalTable: "Alunos",
                        principalColumn: "Registro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroAluno = table.Column<int>(type: "int", nullable: false),
                    AlunoRegistro = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Matriculas_Alunos_AlunoRegistro",
                        column: x => x.AlunoRegistro,
                        principalTable: "Alunos",
                        principalColumn: "Registro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsaveis",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contrante = table.Column<bool>(type: "bit", nullable: false),
                    RegistroAluno = table.Column<int>(type: "int", nullable: false),
                    AlunoRegistro = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsaveis", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Responsaveis_Alunos_AlunoRegistro",
                        column: x => x.AlunoRegistro,
                        principalTable: "Alunos",
                        principalColumn: "Registro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargaHoraria = table.Column<double>(type: "float", nullable: false),
                    BoletimCodigo = table.Column<int>(type: "int", nullable: true),
                    SerieCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Boletins_BoletimCodigo",
                        column: x => x.BoletimCodigo,
                        principalTable: "Boletins",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_Disciplinas_Series_SerieCodigo",
                        column: x => x.SerieCodigo,
                        principalTable: "Series",
                        principalColumn: "Codigo");
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<int>(type: "int", nullable: true),
                    DDD = table.Column<long>(type: "bigint", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoTelefone = table.Column<int>(type: "int", nullable: false),
                    ResponsavelCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Telefones_Responsaveis_ResponsavelCodigo",
                        column: x => x.ResponsavelCodigo,
                        principalTable: "Responsaveis",
                        principalColumn: "Codigo");
                });

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    CodDisciplina = table.Column<int>(type: "int", nullable: false),
                    DisciplinaCodigo = table.Column<int>(type: "int", nullable: false),
                    CodMatricula = table.Column<int>(type: "int", nullable: false),
                    MatriculaCodigo = table.Column<int>(type: "int", nullable: false),
                    BoletimCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Nota_Boletins_BoletimCodigo",
                        column: x => x.BoletimCodigo,
                        principalTable: "Boletins",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_Nota_Disciplinas_DisciplinaCodigo",
                        column: x => x.DisciplinaCodigo,
                        principalTable: "Disciplinas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nota_Matriculas_MatriculaCodigo",
                        column: x => x.MatriculaCodigo,
                        principalTable: "Matriculas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieDisciplina",
                columns: table => new
                {
                    CodSerie = table.Column<int>(type: "int", nullable: false),
                    CodDisciplina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieDisciplina", x => new { x.CodDisciplina, x.CodSerie });
                    table.ForeignKey(
                        name: "FK_SerieDisciplina_Disciplinas_CodDisciplina",
                        column: x => x.CodDisciplina,
                        principalTable: "Disciplinas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerieDisciplina_Series_CodSerie",
                        column: x => x.CodSerie,
                        principalTable: "Series",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CodEndereco",
                table: "Alunos",
                column: "CodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TurmaCodigo",
                table: "Alunos",
                column: "TurmaCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Boletins_AlunoRegistro",
                table: "Boletins",
                column: "AlunoRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_BoletimCodigo",
                table: "Disciplinas",
                column: "BoletimCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_SerieCodigo",
                table: "Disciplinas",
                column: "SerieCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AlunoRegistro",
                table: "Matriculas",
                column: "AlunoRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_BoletimCodigo",
                table: "Nota",
                column: "BoletimCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_DisciplinaCodigo",
                table: "Nota",
                column: "DisciplinaCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_MatriculaCodigo",
                table: "Nota",
                column: "MatriculaCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Responsaveis_AlunoRegistro",
                table: "Responsaveis",
                column: "AlunoRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_SerieDisciplina_CodSerie",
                table: "SerieDisciplina",
                column: "CodSerie");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ResponsavelCodigo",
                table: "Telefones",
                column: "ResponsavelCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_PeriodoId",
                table: "Turma",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_SerieCodigo",
                table: "Turma",
                column: "SerieCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropTable(
                name: "SerieDisciplina");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Responsaveis");

            migrationBuilder.DropTable(
                name: "Boletins");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Periodos");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
