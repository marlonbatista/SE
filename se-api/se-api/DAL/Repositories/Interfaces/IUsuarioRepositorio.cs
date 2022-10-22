using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario CheckLogin(LoginCommand commad)
    }
}
