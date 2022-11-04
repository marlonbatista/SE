using se_api.Context;
using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        private readonly SEContext _context;
        public ResponsavelRepositorio(SEContext context)
        {
            _context = context;
        }

        public Responsavel Alterar(Responsavel dados)
        {
            _context.Set<Responsavel>().UpdateRange(dados);
            _context.SaveChanges();

            Responsavel retorno = ObterPorId(dados.Codigo);
            return retorno;
        }

        public void Inserir(Responsavel dados)
        {
            _context.Set<Responsavel>().AddRange(dados);
            _context.SaveChanges();
        }

        public Responsavel ObterPorId(int id)
        {
            return _context.Find<Responsavel>(id);
        }

        public List<Responsavel> ObterTodos()
        {
            return _context.Responsaveis.ToList<Responsavel>();
        }
    }
}
