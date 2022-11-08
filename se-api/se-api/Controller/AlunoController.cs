using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using se_api.Commands;
using se_api.Controller.DTO;
using se_api.Controller.DTO.Entrada;
using se_api.DAL;
using se_api.DAL.Repositories.Interfaces;
using se_api.Models;

namespace se_api.Controller
{
    [EnableCors("_seapi")]
    [ApiController]
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepositorio _repositorio;

        public AlunoController(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("{nome}")]
        [Authorize]
        public IList<Aluno> ObterPorNome(string nome)
        {
            return _repositorio.BuscarPorNome(nome);
        }

        [HttpGet("{registro}")]
        [Authorize]
        public Aluno ObterPorRegistro([FromBody] int registro)
        {
            return _repositorio.BuscarPorRegistro(registro);
        }

        [HttpPost]
        [Authorize]
        public void Inserir([FromBody] AlunoEntrada dados)
        {
            Aluno aluno;
            if(dados != null)
            {
                aluno = ConverteAlunoEntrada(dados);
                _repositorio.Inserir(aluno);
            }
        }

        [HttpPut]
        [Authorize]
        public Aluno Atualizar([FromBody] Aluno dados)
        {
            return _repositorio.Alterar(dados);
        }

        private Aluno ConverteAlunoEntrada(AlunoEntrada dados)
        {
            Aluno aluno;
            Endereco endereco = new Endereco
            {
                Cidade = dados.Endereco.Cidade,
                Bairro = dados.Endereco.Bairro,
                CEP = dados.Endereco.CEP,
                Lougradouro = dados.Endereco.Lougradouro,
                Complemento = dados.Endereco.Complemento,
                Estado = dados.Endereco.Estado,
                Numero = dados.Endereco.Numero,
                Referencia = dados.Endereco.Referencia
            };

            List<Responsavel> responsaveis = new List<Responsavel>();
            foreach (var respo in dados.Responsaveis)
            {
                List<Telefone> telefones = new List<Telefone>();
                foreach (var telefone in respo.Telefones)
                {
                    telefones.Add(new Telefone
                    {
                        DDD = telefone.DDD,
                        Numero = telefone.Numero,
                        Pais = telefone.Pais,
                        TipoTelefone = telefone.TipoTelefone
                    });
                }
                responsaveis.Add(new Responsavel
                {
                    Contrante = respo.Contrante,
                    CPF = respo.CPF,
                    Nome = respo.Nome,
                    SobreNome = respo.SobreNome,
                    RG = respo.RG,
                    Telefones = telefones
                });
                }
            aluno = new Aluno
            {
                Nome = dados.Nome,
                SobreNome = dados.SobreNome,
                RG = dados.RG,
                CPF = dados.CPF,
                DataNascimento = dados.DataNascimento,
                Responsaveis = responsaveis,
                localNascimento = dados.localNascimento,
                Endereco = endereco,

            };
                
            return aluno;
        }
    }
}
