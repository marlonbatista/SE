using System.ComponentModel.DataAnnotations;

namespace se_api.Models
{
    public class Telefone
    {
        [Key]
        public int Codigo { get; set; }

        public int? Pais { get; set; }
        [Required(ErrorMessage = "Necessário informa o DDD")]
        public uint DDD { get; set; }
        [Required(ErrorMessage = "Necessário informa o número do telefone")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Necessário informa o tipo do telefone")]
        public TipoTelefone TipoTelefone { get; set; }
    }
}