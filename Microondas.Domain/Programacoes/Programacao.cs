namespace Microondas.Domain.Programacoes
{
    public class Programacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string Instrucoes { get; set; }

        public Programacao(string nome, string alimento, int tempo, int potencia, string instrucoes)
        {
            Nome = nome;
            Alimento = alimento;
            Tempo = tempo;
            Potencia = potencia;
            Instrucoes = instrucoes;
        }
    }
}
