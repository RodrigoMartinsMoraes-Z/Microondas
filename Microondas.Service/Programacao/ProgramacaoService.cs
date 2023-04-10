using Microondas.Interface.Programacao;

using System.Threading.Tasks;

namespace Microondas.Service.Programacao
{
    public class ProgramacaoService : IProgramacaoService
    {
        private readonly IProgramacaoRepository _repository;

        public ProgramacaoService(IProgramacaoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Domain.Programacoes.Programacao[]> GetProgramacoes()
        {
            return await _repository.GetProgramacoes();
        }
    }
}
