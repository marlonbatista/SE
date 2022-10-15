using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class Aluno : Humano
    {
        [Key]
        public int Registro { get; set; }
        [Required]
        public DateTime  DataNascimento { get; set; }
        public List<Responsavel> Responsaveis  { get; set; }
        [Required]
        public string localNascimento { get; set; }
        [ForeignKey("Endereco")]
        public int CodEndereco { get; set; }    
        public Endereco Endereco { get; set; }

        public Aluno()
        {
        }

        public Aluno(int matricula,
            string nome, 
            string sobreNome, 
            string rg, 
            string cpf,
            DateTime dataNascimento, 
            List<Responsavel> responsaveis, 
            string localNascimento, 
            Endereco endereco)
        {
            Registro = matricula;
            DataNascimento = dataNascimento;
            Responsaveis = responsaveis;
            this.localNascimento = localNascimento;
            Endereco = endereco;
            Nome = nome;
            SobreNome = sobreNome;
            CPF = cpf;
            RG = rg;
        }
    }
}
