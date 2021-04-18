namespace CadastrarMedico.Models
{
    public class Medicos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public bool Cooperador { get; set; }
        public string UnidadeAtendimento { get; set; }
        public bool AtendeSUS { get; set; }
        public bool FoiVisitado { get; set; }
        public bool TemKit { get; set; }
        public int Telefone { get; set; }
        public string observacoes { get; set; }
    }
}
