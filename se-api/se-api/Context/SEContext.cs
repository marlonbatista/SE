using Microsoft.EntityFrameworkCore;
using se_api.Context.Config;
using se_api.Models;

namespace se_api.Context
{
    public class SEContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Boletim> Boletins { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Setting.ConnectionString);
        }

    }
}
