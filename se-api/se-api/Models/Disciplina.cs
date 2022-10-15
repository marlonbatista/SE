namespace se_api.Models
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double CargaHoraria { get; set; }

        public Disciplina()
        {
        }

        public Disciplina(int codigo, string nome, double cargaHoraria)
        {
            Codigo = codigo;
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }
    }
}
