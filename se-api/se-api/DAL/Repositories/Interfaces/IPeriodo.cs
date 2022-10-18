using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface IPeriodo : IRepositorio<Periodo>
    {
        Periodo Consultar(string turno);
    }
}
