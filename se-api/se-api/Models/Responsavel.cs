using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Responsavel : Humano
    {
        [Key]
        public int Codigo { get; set; }
        public List<Telefone> Telefones { get; set; }
        [Required(ErrorMessage = "Necessario informa se é contrantante")]
        public bool Contrante { get; set; }
        [ForeignKey("Aluno")]
        public int RegistroAluno { get; set; }
        public Aluno Aluno { get; set; }

        public string Tipo { get; set; }

        public Responsavel()
        {
        }

        public Responsavel(
            int codigo, 
            string nome, 
            string sobreNome, 
            string cpf, 
            string rg, 
            List<Telefone> telefones, 
            bool contrante,
            string tipo,
            int registroAluno)
        {
            Codigo = codigo;
            Telefones = telefones;
            Contrante = contrante;
            Tipo = tipo;
            Nome = nome;
            SobreNome = sobreNome;
            CPF = cpf;
            RG = rg;
            RegistroAluno = registroAluno;

        }
    }
}
