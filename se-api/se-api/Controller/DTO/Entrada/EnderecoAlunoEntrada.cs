using System.ComponentModel.DataAnnotations;

namespace se_api.Controller.DTO.Entrada
{
    public class EnderecoAlunoEntrada
    {
        [Required(ErrorMessage = "Necessario informa o logradouro")]
        public string Lougradouro { get; set; }
        [Required(ErrorMessage = "Necessario informa um número válido")]
        public int Numero { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Necessario informa o bairro")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Necessario informa a cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Necessario informa o estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Necessario informa o CEP")]
        public string CEP { get; set; }
        public string? Referencia { get; set; }
    }
}
