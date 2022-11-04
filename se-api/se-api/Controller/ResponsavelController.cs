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
    [Route("responsavel")]
    public class ResponsavelController : ControllerBase
    {
        private readonly IResponsavelRepositorio _repositorio;

        public ResponsavelController(IResponsavelRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        [Authorize]
        public IList<Responsavel> Obter()
        {
            return _repositorio.ObterTodos();
            
        }

        [HttpGet("{codigo}")]
        [Authorize]
        public Responsavel ObterPorId([FromBody] int codigo)
        {
            return _repositorio.ObterPorId(codigo);

        }

        [HttpPost]
        [Authorize]
        public void Inserir([FromBody] Responsavel dados)
        {
            _repositorio.Inserir(dados);
        }
    }
}
