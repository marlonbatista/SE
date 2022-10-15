using System.ComponentModel.DataAnnotations;

namespace se_api.Models
{
    public class Endereco
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Necessario informa o lougradouro")]
        public string Lougradouro { get; set; }
        [Required(ErrorMessage ="Necessario informa um número válido")]
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

        public Endereco()
        {
        }

        public Endereco(int codigo, string lougradouro, int numero, string complemento, string bairro, string cidade, string estado, string cEP, string? referencia)
        {
            Codigo = codigo;
            Lougradouro = lougradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cEP;
            Referencia = referencia;
        }
    }
}
