using System.Threading.Tasks;

namespace Microondas.Interface.Programacao
{
    public interface IProgramacaoRepository
    {
        Task<Domain.Programacoes.Programacao[]> GetProgramacoes();
    }
}
