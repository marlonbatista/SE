using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using se_api.Commands;
using se_api.Controller.DTO;
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
        public void Inserir([FromBody] Aluno dados)
        {
            _repositorio.Inserir(dados);
        }

        [HttpPut]
        [Authorize]
        public Aluno Atualizar([FromBody] Aluno dados)
        {
            return _repositorio.Alterar(dados);
        }
    }
}
