using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public interface ITurmaRepositorio: IRepositorio<Turma>
    {
        Aluno BuscarAlunoPorMatricula(int codMatricula);
        void DesvincularAluno(int registroAluno);
    }
}
