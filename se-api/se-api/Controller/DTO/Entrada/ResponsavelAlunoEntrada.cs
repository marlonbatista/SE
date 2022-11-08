using System.ComponentModel.DataAnnotations;

namespace se_api.Controller.DTO.Entrada
{
    public class ResponsavelAlunoEntrada
    {
        [Required(ErrorMessage = "Necessario informa o nome do responsável")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Necessario informa o sobrenome")]
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        [Required(ErrorMessage = "Necessario informar o RG")]
        public string RG { get; set; }
        public List<TelefoneResponsavelEntrada> Telefones { get; set; }
        [Required(ErrorMessage = "Necessario informa se é contrantante")]
        public bool Contrante { get; set; }
        [Required(ErrorMessage = "Necessario informa o o grau de parentesco")]
        public string Tipo { get; set; }
    }
}
