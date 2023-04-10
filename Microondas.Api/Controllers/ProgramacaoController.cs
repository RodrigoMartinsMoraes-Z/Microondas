using Microondas.Interface.Programacao;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Microondas.Api.Controllers
{
    [RoutePrefix("programacao")]
    public class ProgramacaoController : ApiController
    {
        private readonly IProgramacaoService _service;

        public ProgramacaoController(IProgramacaoService service)
        {
            _service = service;
        }

        [HttpGet, Route()]
        public async Task<Domain.Programacoes.Programacao[]> BuscarProgramacoes()
        {
            var programacoes = await _service.GetProgramacoes();
            return programacoes;
        }
    }
}
