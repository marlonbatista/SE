using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface IBoletimRepositorio : IRepositorio<Boletim>
    {
        Boletim BuscarPorAluno(int registroAluno);
        List<Boletim> BuscarPorTurma(int codTurma);
        List<Boletim> BuscarPorSerie(int codSerie);
    }
}
