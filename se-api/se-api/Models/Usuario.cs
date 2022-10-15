using System.ComponentModel.DataAnnotations;

namespace se_api.Models
{
    public class Usuario : Humano
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Necessario informa o e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Necessario informa o tipo do usuário")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Necessario informa a senha")]
        public string Senha { get; set; }

        public Usuario()
        {
        }

        public Usuario(int codigo, 
            string nome, 
            string sobreNome, 
            string cpf, 
            string rg, 
            string email, 
            string tipo, 
            string senha) 
        {
            Codigo = codigo;
            Email = email;
            Tipo = tipo;
            Senha = senha;
            Nome = nome;
            SobreNome = sobreNome;
            CPF = cpf;
            RG = rg;
        }
    }
}
