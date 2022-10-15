using System.ComponentModel.DataAnnotations;

namespace se_api.Models
{
    public class Periodo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Necessario informa o turno")]
        public string Turno { get; set; }
        [Required(ErrorMessage = "Necessario informa o horário do turno")]
        public DateTime Horario { get; set; }

        public Periodo()
        {
        }

        public Periodo(int id, string turno, DateTime horario)
        {
            Id = id;
            Turno = turno;
            Horario = horario;
        }

        public void Inserir(Periodo periodo)
        {
            // fazer a inserção dos dados no banco
        }

        public Periodo Consultar(string turno)
        {
            // fazer consultar no banco de dados para retornar o turno
            return new Periodo();
        }
    }
}
