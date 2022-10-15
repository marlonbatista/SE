namespace se_api.Models
{
    public class Turma
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int codPeriodo { get; set; }
        public Periodo Periodo { get; set; }
        public int codSerie { get; set; }
        public Serie Serie { get; set; }
        public uint Ano { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma(int codigo, string nome, int codPeriodo, Periodo periodo, int codSerie, Serie serie, uint ano, List<Aluno> alunos)
        {
            Codigo = codigo;
            Nome = nome;
            this.codPeriodo = codPeriodo;
            Periodo = periodo;
            this.codSerie = codSerie;
            Serie = serie;
            Ano = ano;
            Alunos = alunos;
        }
    }
}
