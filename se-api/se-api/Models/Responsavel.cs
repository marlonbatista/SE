using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Responsavel : Humano
    {
        [Key]
        public Guid Codigo { get; set; }
        [ForeignKey("Telefone")]
        public int CodTelefone { get; set; }
        public List<Telefone> Telefones { get; set; }
        [Required(ErrorMessage = "Necessario informa se é contrantante")]
        public bool Contrante { get; set; }
        [Required(ErrorMessage = "Necessario informa o tipo do responsavel")]
        public string Tipo { get; set; }

        public Responsavel()
        {
        }

        public Responsavel(
            Guid codigo, 
            string nome, 
            string sobreNome, 
            string cpf, 
            string rg, 
            List<Telefone> telefones, 
            bool contrante,
            string tipo)
        {
            Codigo = Guid.NewGuid();
            Telefones = telefones;
            Contrante = contrante;
            Tipo = tipo;
        }
    }
}
