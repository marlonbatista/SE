using se_api.Commands;
using se_api.Context;
using se_api.DAL.Repositories.Interfaces;
using se_api.Models;
using se_api.Util;

namespace se_api.DAL
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SEContext _context;

        public UsuarioRepositorio(SEContext context)
        {
            _context = context;
        }

        public Usuario Alterar(Usuario dados)
        {
            _context.Set<Usuario>().UpdateRange(dados);
            _context.SaveChanges();

            Usuario retorno = ObterPorId(dados.Codigo);
            return retorno;
        }

        public Usuario CheckLogin(LoginCommand commad)
        {
            commad.Senha = Function.EncodeHash(commad.Senha);
            IQueryable<Usuario> query = _context.Usuarios.Where<Usuario>(e => e.Email == commad.Login && e.Senha == commad.Senha)
                                                                        .Select(usuario => new Usuario
                                                                        {
                                                                            Codigo = usuario.Codigo,
                                                                            Senha = usuario.Senha,
                                                                            CPF = usuario.CPF,
                                                                            RG = usuario.RG,
                                                                            Email = usuario.Email,
                                                                            Nome = usuario.Nome,
                                                                            SobreNome = usuario.SobreNome,
                                                                            Tipo = usuario.Tipo,
                                                                        });
            if(query.Count() < 1)
                return null;

            Usuario usuario = new Usuario();
            foreach (var user in query)
                usuario = user;
           
            return usuario.Codigo != 0 ? usuario : null;
        }

        public void Inserir(Usuario dados)
        {
            if (dados.Codigo != null)
                dados.Codigo = 0;
            dados.Senha = Function.EncodeHash(dados.Senha);
            _context.Set<Usuario>().AddRange(dados);
            _context.SaveChanges();
        }

        public Usuario ObterPorId(int id)
        {
            return _context.Find<Usuario>(id);
        }

        public List<Usuario> ObterTodos()
        {
            return _context.Usuarios.ToList<Usuario>();
        }
    }
}
