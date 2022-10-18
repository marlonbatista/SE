using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface IDisciplinaRepositorio : IRepositorio<Disciplina>
    {
        Disciplina BuscarPorNome(string nome);
    }
}
