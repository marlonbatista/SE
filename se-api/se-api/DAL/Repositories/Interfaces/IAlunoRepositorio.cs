using se_api.Controller.DTO.Entrada;
using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface IAlunoRepositorio : IRepositorio<Aluno>
    {
        Aluno BuscarPorRegistro(int registro);
        List<Aluno> BuscarPorNome(string nome);
    }
}
