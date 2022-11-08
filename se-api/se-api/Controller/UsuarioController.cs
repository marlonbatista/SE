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
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        [Authorize]
        public IList<UsuarioDTO> Obter()
        {
            IList<Usuario> usuarios = _repositorio.ObterTodos();
            IList<UsuarioDTO> usuariosDtos = new List<UsuarioDTO>();

            foreach (var usuario in usuarios)
            {
                usuariosDtos.Add(new UsuarioDTO
                {
                    Codigo = usuario.Codigo,
                    Email = usuario.Email,
                    Nome = usuario.Nome,
                    SobreNome = usuario.SobreNome,
                    Tipo = usuario.Tipo
                });
            }
            return usuariosDtos;
        }

        [HttpGet("{codigo}")]
        [Authorize]
        public UsuarioDTO ObterPorId([FromBody] int codigo)
        {
            Usuario usuario = _repositorio.ObterPorId(codigo);
            return new UsuarioDTO 
            { 
                Codigo = usuario.Codigo,
                Email = usuario.Email,
                Nome = usuario.Nome,
                SobreNome = usuario.SobreNome,
                Tipo = usuario.Tipo
            };
        }

        [HttpPost]
        [Authorize]
        public void Inserir([FromBody] Usuario dados)
        {

            _repositorio.Inserir(dados);
        }
    }
}
