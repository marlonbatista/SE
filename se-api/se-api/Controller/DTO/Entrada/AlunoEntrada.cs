using System.ComponentModel.DataAnnotations;

namespace se_api.Controller.DTO.Entrada
{
    public class AlunoEntrada
    {
        [Required(ErrorMessage = "Necessario informa o nome do aluno")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Necessario informa o sobrenome do aluno")]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "Necessario informa o CPF do aluno")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Necessario informa o RG do aluno")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Necessario informa o número da certidão")]
        public int Registro { get; set; }
        [Required(ErrorMessage = "Necessario informa a data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public List<ResponsavelAlunoEntrada> Responsaveis { get; set; }
        [Required(ErrorMessage = "Necessario informa o local de nascimento")]
        public string localNascimento { get; set; }

        public EnderecoAlunoEntrada Endereco { get; set; }
        //"Nome": "Roberto",
        //"SobreNome": "Almeida",
        //"Rg": "098123456",
        //"CPF": "19812345670",
        //"NumeroCertidaoNascimento": "123456789",
        //"localNascimento": "Monte Alegre",
        //"Endereco": {
        //    "Lougradouro": "Rua dos Tomates Dourados",
        //    "Numero": 1279,
        //    "Complemento": "Fundo A",
        //    "Bairro": "Jardim das Palmeiras",
        //    "Cidade": "São Carlos",
        //    "Estado": "SP",
        //    "CEP": "15809357",
        //    "Referencia": "Padaria FornoBelo"
        //},
        //"Responsaveis": [
        //    {
        //        "Nome": "Roberta",
        //        "SobreNome": "Almeida",
        //        "Rg": "978912345",
        //        "CPF": "70113824678",
        //        "Contratante": true,
        //        "Tipo": "Mãe",
        //        "Telefones": [
        //            {
        //                "Pais": 55,
        //                "DDD": 16,
        //                "Numero": "99999-0911",
        //                "TipoTelefone": 1
        //            }
        //        ]
        //    }


    }
}
    
