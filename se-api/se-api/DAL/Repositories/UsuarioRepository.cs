using se_api.DAL.Repositories.Interfaces;
using se_api.Models;

namespace se_api.DAL
{
    public class UsuarioRepository : IUsuarioRepositorio
    {
        public Usuario Alterar()
        {
            throw new NotImplementedException();
        }

        public Usuario Alterar(Usuario dados)
        {
            throw new NotImplementedException();
        }

        public void Inserir()
        {
            throw new NotImplementedException();
        }

        public void Inserir(Usuario dados)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterTodos()
        {
            throw new NotImplementedException();
        }

        List<Usuario> IRepositorio<Usuario>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
