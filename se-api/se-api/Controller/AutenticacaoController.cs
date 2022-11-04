using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using se_api.Commands;
using se_api.DAL.Repositories.Interfaces;
using se_api.Models;
using se_api.Service;

namespace se_api.Controller
{
    [ApiController]
    [EnableCors("_seapi")]
    [Route("autenticacao")]
    [AllowAnonymous]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioRepositorio _repositorio;

        public AutenticacaoController(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        // POST: AutenticacaoController/Create
        [HttpPost]
        public object Autenticar([FromBody] LoginCommand dados)
        {
            Usuario usuario = _repositorio.CheckLogin(dados);
            if (usuario == null)
            {
                return NotFound("Login ou senha parece estar incorreto");
            }
            var token = TokenService.ObterToken(dados);
            return new
            {
                Codigo = usuario.Codigo,
                Token = token,
                Nome = $"{ usuario.Nome + " " + usuario.SobreNome }"
            };
        }
    }
}