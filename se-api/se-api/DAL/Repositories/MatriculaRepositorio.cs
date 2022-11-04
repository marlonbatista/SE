using se_api.Context;
using se_api.Models;

namespace se_api.DAL.Repositories.Interfaces
{
    public class MatriculaRepositorio : IMatriculaRepositorio
    {
        private readonly SEContext _context;
        public MatriculaRepositorio(SEContext context)
        {
            _context = context;
        }

        public Matricula Alterar(Matricula dados)
        {
            _context.Set<Matricula>().UpdateRange(dados);
            _context.SaveChanges();

            Matricula retorno = ObterPorId(dados.Codigo);
            return retorno;
        }

        public Matricula Buscar(int registroAluno, int codTurma)
        {
            var matriculas = _context.Matriculas
                .Where<Matricula>(x => x.RegistroAluno == registroAluno && x.CodTurma == codTurma);

            return matriculas.FirstOrDefault<Matricula>();
        }

        public void Desmatricular(Matricula matricula)
        {
            matricula.Ativo = false;
            Alterar(matricula);
        }

        public void Inserir(Matricula dados)
        {
            _context.Set<Matricula>().AddRange(dados);
            _context.SaveChanges();
        }

        public Matricula ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Matricula> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
