using System.Threading.Tasks;

namespace Microondas.Interface.Programacao
{
    public interface IProgramacaoService
    {
        Task<Domain.Programacoes.Programacao[]> GetProgramacoes();
    }
}
