namespace se_api.Models
{
    public class Telefone
    {
        public int Codigo { get; set; }
        public int? Pais { get; set; }
        public uint DDD { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
    }
}