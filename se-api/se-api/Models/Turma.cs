using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Turma
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage ="Necessário informar o nome da turma")]
        public string Nome { get; set; }
        [ForeignKey("Periodos")]
        public int codPeriodo { get; set; }
        public Periodo Periodo { get; set; }
        [ForeignKey("Series")]
        public int codSerie { get; set; }
        public Serie Serie { get; set; }
        [Required(ErrorMessage = "Necessário informa o ano")]
        public int Ano { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma()
        {
        }

        public Turma(int codigo, string nome, int codPeriodo, Periodo periodo, int codSerie, Serie serie, int ano, List<Aluno> alunos)
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
