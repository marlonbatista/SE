namespace se_api.DAL.Repositories.Interfaces
{
    public interface IRepositorio<T>
    {
        T ObterPorId(int id);
        List<T> ObterTodos();
        void Inserir(T dados);
        T Alterar(T dados);
    }
}
