using System.ComponentModel.DataAnnotations;

namespace se_api.Models
{
    public class Serie
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage ="Necessário informar a descrição da série")]
        public string Descricao { get; set; }
        // turma e disciplinas
        public List<Turma> Turmas { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Serie()
        {
        }

        public Serie(int codigo, string descricao, List<Turma> turmas, List<Disciplina> disciplinas)
        {
            Codigo = codigo;
            Descricao = descricao;
            Turmas = turmas;
            Disciplinas = disciplinas;
        }
    }
}