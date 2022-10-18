using System.ComponentModel.DataAnnotations;

namespace se_api.Models
{
    public class Disciplina
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Necessário informar o nome da disciplina")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Necessário informar a carga horária")]
        public double CargaHoraria { get; set; }
        public List<SerieDisciplina> SerieDisciplinas { get; set; }

        public Disciplina()
        {
        }

        public Disciplina(int codigo, string nome, double cargaHoraria)
        {
            Codigo = codigo;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            SerieDisciplinas = new List<SerieDisciplina>();
        }
    }
}
