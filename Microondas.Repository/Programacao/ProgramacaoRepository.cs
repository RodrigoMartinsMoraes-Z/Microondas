using Microondas.Interface.Programacao;

using System.Threading.Tasks;

namespace Microondas.Repository.Programacao
{
    public class ProgramacaoRepository : IProgramacaoRepository
    {
        /// <summary>
        /// por enquanto simula uma chamada para o banco e retorna uma lista de programacoes pré definidas
        /// </summary>
        /// <returns></returns>
        public Task<Domain.Programacoes.Programacao[]> GetProgramacoes()
        {
            Domain.Programacoes.Programacao[] programas = new Domain.Programacoes.Programacao[5];

            programas[0] = new Domain.Programacoes.Programacao("Pipoca", "Pipoca (de micro-ondas)", 3, 7, "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.");
            programas[1] = new Domain.Programacoes.Programacao("Leite", "Leite", 5, 5, "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.");
            programas[2] = new Domain.Programacoes.Programacao("Carnes de boi", "Carne em pedaço ou fatias", 14, 4, "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.");
            programas[3] = new Domain.Programacoes.Programacao("Frango", "Frango (qualquer corte)", 8, 7, "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.");
            programas[4] = new Domain.Programacoes.Programacao("Feijão", "Feijão congelado", 8, 9, "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.");

            return Task.FromResult(programas);
        }
    }
}
