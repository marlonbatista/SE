using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface IMatriculaRepositorio : IRepositorio<Matricula>
    {
        Matricula Buscar(int registroAluno, int codSerie);
        void Desmatricular(Matricula matricula);
    }
}
