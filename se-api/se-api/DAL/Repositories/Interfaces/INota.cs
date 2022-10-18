using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface INota: IRepositorio<Nota>
    {
        Nota BuscarPorAlunoESerie(int registroAluno, int serie);
    }
}
