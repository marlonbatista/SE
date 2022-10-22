using se_api.Context;
using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly SEContext _context;
        public AlunoRepositorio(SEContext context)
        {
            _context = context;
        }

        public Aluno Alterar(Aluno dados)
        {
            _context.Set<Aluno>().UpdateRange(dados);
            _context.SaveChanges();

            Aluno retorno = BuscarPorRegistro(dados.Registro);
            return retorno;
        }

        public List<Aluno> BuscarPorNome(string nome)
        {
            try
            {
                List<Aluno> alunos = new List<Aluno>();
                IQueryable<Aluno> query = from a in _context.Alunos
                            where a.Nome.Contains(nome)
                            select a;
                if(alunos.Count > 0)
                {
                    alunos = query.ToList();
                    return alunos;
                } else
                {
                    return null;
                }
                    
            }
            catch (Exception ex)
            {

                throw new Exception("BuscarPorNome : " + ex.Message);
            }
        }

        public Aluno BuscarPorRegistro(int registro)
        {
            return _context.Find<Aluno>(registro);
        }

        public void Inserir(Aluno dados)
        {
            _context.Set<Aluno>().AddRange(dados);
            _context.SaveChanges();
        }

        public Aluno ObterPorId(int id)
        {
            return this.BuscarPorRegistro(id);
        }

        public List<Aluno> ObterTodos()
        {
            return _context.Alunos.ToList<Aluno>();
        }
    }
}
