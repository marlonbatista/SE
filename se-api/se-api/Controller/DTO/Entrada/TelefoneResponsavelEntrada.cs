using se_api.Models;
using System.ComponentModel.DataAnnotations;

namespace se_api.Controller.DTO.Entrada
{
    public class TelefoneResponsavelEntrada
    {
        public int? Pais { get; set; }
        [Required(ErrorMessage = "Necessário informa o DDD")]
        public uint DDD { get; set; }
        [Required(ErrorMessage = "Necessário informa o número do telefone")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Necessário informa o tipo do telefone")]
        public TipoTelefone TipoTelefone { get; set; }
    }
}
