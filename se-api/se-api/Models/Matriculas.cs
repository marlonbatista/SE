using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Matriculas
    {
        [Key]
        public int Codigo { get; set; }
        [ForeignKey("Aluno")]
        public int CodAluno { get; set; }
        public Aluno Aluno { get; set; }
        [Required(ErrorMessage = "Necessario informa o numero")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Necessario informa a data inicio")]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "Necessario informa a data fim")]
        public DateTime DataFim { get; set; }
        [Required(ErrorMessage = "Necessario informa se ativo ou não")]
        public bool Ativo  { get; set; }

        public Matriculas()
        {
        }

        public Matriculas(int codigo, int codAluno, Aluno aluno, int numero, DateTime dataInicio, DateTime dataFim, bool ativo)
        {
            Codigo = codigo;
            CodAluno = codAluno;
            Aluno = aluno;
            Numero = numero;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Ativo = ativo;
        }
    }
}
