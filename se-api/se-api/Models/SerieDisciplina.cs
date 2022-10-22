using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se_api.Models
{
    public class SerieDisciplina
    {
        
        [ForeignKey("Serie")]
        public int CodSerie { get; set; }
        public Serie Serie { get; set; }
        [ForeignKey("Disciplina")]
        public int CodDisciplina { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
