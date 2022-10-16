using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Boletim
    {
        [Key]
        public int Codigo { get; set; }
        [ForeignKey("Alunos")]
        public int CodAluno { get; set; }
        public Aluno Aluno { get; set; }
        public List<Nota> Notas { get; set; }
        [Required(ErrorMessage ="Necessario informar o número de faltas")]
        public int Faltas { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Boletim()
        {
        }

        public Boletim(int codigo, int codAluno, Aluno aluno, List<Nota> notas, int faltas, List<Disciplina> disciplinas)
        {
            Codigo = codigo;
            CodAluno = codAluno;
            Aluno = aluno;
            Notas = notas;
            Faltas = faltas;
            Disciplinas = disciplinas;
        }
    }
}
