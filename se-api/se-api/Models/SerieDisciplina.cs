namespace se_api.Models
{
    public class SerieDisciplina
    {
        public int CodSerie { get; set; }
        public Serie Serie { get; set; }
        public int CodDisciplina { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
