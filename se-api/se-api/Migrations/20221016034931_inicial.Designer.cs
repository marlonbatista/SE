﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using se_api.Context;

#nullable disable

namespace se_api.Migrations
{
    [DbContext(typeof(SEContext))]
    [Migration("20221016034931_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("se_api.Models.Aluno", b =>
                {
                    b.Property<int>("Registro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Registro"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodEndereco")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TurmaCodigo")
                        .HasColumnType("int");

                    b.Property<string>("localNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Registro");

                    b.HasIndex("CodEndereco");

                    b.HasIndex("TurmaCodigo");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("se_api.Models.Boletim", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<int>("AlunoRegistro")
                        .HasColumnType("int");

                    b.Property<int>("CodAluno")
                        .HasColumnType("int");

                    b.Property<int>("Faltas")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("AlunoRegistro");

                    b.ToTable("Boletins");
                });

            modelBuilder.Entity("se_api.Models.Disciplina", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<int?>("BoletimCodigo")
                        .HasColumnType("int");

                    b.Property<double>("CargaHoraria")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SerieCodigo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("BoletimCodigo");

                    b.HasIndex("SerieCodigo");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("se_api.Models.Endereco", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lougradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("se_api.Models.Matricula", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<int>("AlunoRegistro")
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CodAluno")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("AlunoRegistro");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("se_api.Models.Nota", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<int?>("BoletimCodigo")
                        .HasColumnType("int");

                    b.Property<int>("CodDisciplina")
                        .HasColumnType("int");

                    b.Property<int>("CodMatricula")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaCodigo")
                        .HasColumnType("int");

                    b.Property<int>("MatriculaCodigo")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("BoletimCodigo");

                    b.HasIndex("DisciplinaCodigo");

                    b.HasIndex("MatriculaCodigo");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("se_api.Models.Periodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Periodos");
                });

            modelBuilder.Entity("se_api.Models.Responsavel", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AlunoRegistro")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Contrante")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.HasIndex("AlunoRegistro");

                    b.ToTable("Responsaveis");
                });

            modelBuilder.Entity("se_api.Models.Serie", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("se_api.Models.Telefone", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<long>("DDD")
                        .HasColumnType("bigint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pais")
                        .HasColumnType("int");

                    b.Property<Guid?>("ResponsavelCodigo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoTelefone")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("ResponsavelCodigo");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("se_api.Models.Turma", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodoId")
                        .HasColumnType("int");

                    b.Property<int>("SerieCodigo")
                        .HasColumnType("int");

                    b.Property<int>("codPeriodo")
                        .HasColumnType("int");

                    b.Property<int>("codSerie")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("PeriodoId");

                    b.HasIndex("SerieCodigo");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("se_api.Models.Usuario", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("se_api.Models.Aluno", b =>
                {
                    b.HasOne("se_api.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("CodEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("se_api.Models.Turma", null)
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaCodigo");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("se_api.Models.Boletim", b =>
                {
                    b.HasOne("se_api.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoRegistro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("se_api.Models.Disciplina", b =>
                {
                    b.HasOne("se_api.Models.Boletim", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("BoletimCodigo");

                    b.HasOne("se_api.Models.Serie", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("SerieCodigo");
                });

            modelBuilder.Entity("se_api.Models.Matricula", b =>
                {
                    b.HasOne("se_api.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoRegistro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("se_api.Models.Nota", b =>
                {
                    b.HasOne("se_api.Models.Boletim", null)
                        .WithMany("Notas")
                        .HasForeignKey("BoletimCodigo");

                    b.HasOne("se_api.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("se_api.Models.Matricula", "Matricula")
                        .WithMany()
                        .HasForeignKey("MatriculaCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("se_api.Models.Responsavel", b =>
                {
                    b.HasOne("se_api.Models.Aluno", null)
                        .WithMany("Responsaveis")
                        .HasForeignKey("AlunoRegistro");
                });

            modelBuilder.Entity("se_api.Models.Telefone", b =>
                {
                    b.HasOne("se_api.Models.Responsavel", null)
                        .WithMany("Telefones")
                        .HasForeignKey("ResponsavelCodigo");
                });

            modelBuilder.Entity("se_api.Models.Turma", b =>
                {
                    b.HasOne("se_api.Models.Periodo", "Periodo")
                        .WithMany()
                        .HasForeignKey("PeriodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("se_api.Models.Serie", "Serie")
                        .WithMany("Turmas")
                        .HasForeignKey("SerieCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Periodo");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("se_api.Models.Aluno", b =>
                {
                    b.Navigation("Responsaveis");
                });

            modelBuilder.Entity("se_api.Models.Boletim", b =>
                {
                    b.Navigation("Disciplinas");

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("se_api.Models.Responsavel", b =>
                {
                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("se_api.Models.Serie", b =>
                {
                    b.Navigation("Disciplinas");

                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("se_api.Models.Turma", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
