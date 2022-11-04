using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Matricula
    {
        [Key]
        public int Codigo { get; set; }
        [ForeignKey("Alunos")]
        public int RegistroAluno { get; set; }
        public Aluno Aluno { get; set; }
        [Required(ErrorMessage = "Necessario informa o numero")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Necessario informa a data inicio")]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "Necessario informa a data fim")]
        public DateTime DataFim { get; set; }
        [Required(ErrorMessage = "Necessario informa se ativo ou não")]
        public bool Ativo  { get; set; }
        [ForeignKey("Turma")]
        public int CodTurma { get; set; }
        public Turma Turma { get; set; }

        public Matricula()
        {
        }
    }
}
