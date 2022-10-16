using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Nota
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage="Favor informar o valor da nota")]
        public double Valor { get; set; }
        [ForeignKey("Disciplinas")]
        public int CodDisciplina { get; set; }
        public Disciplina Disciplina { get; set; }
        [ForeignKey("Matriculas")]
        public int CodMatricula { get; set; }
        public Matricula Matricula { get; set; }

        public Nota()
        {
        }

        public Nota(int codigo, double valor, int codDisciplina, Disciplina disciplina, int codMatricula, Matricula matricula)
        {
            Codigo = codigo;
            Valor = valor;
            CodDisciplina = codDisciplina;
            Disciplina = disciplina;
            CodMatricula = codMatricula;
            Matricula = matricula;
        }
    }
}