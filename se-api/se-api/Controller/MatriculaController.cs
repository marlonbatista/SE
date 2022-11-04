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
    [Route("matricula")]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaRepositorio _repositorio;

        public MatriculaController(IMatriculaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        [Authorize]
        public IList<Matricula> Obter()
        {
            return _repositorio.ObterTodos();
        }

        [HttpGet("{codigo}")]
        [Authorize]
        public Matricula ObterPorId([FromBody] int codigo)
        {
            return _repositorio.ObterPorId(codigo);
            
        }

        [HttpPost]
        [Authorize]
        public void Inserir([FromBody] Matricula dados)
        {

            _repositorio.Inserir(dados);
        }
    }
}
