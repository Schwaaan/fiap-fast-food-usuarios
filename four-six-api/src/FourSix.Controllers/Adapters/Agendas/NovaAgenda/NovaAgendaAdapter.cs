using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Agendas.NovaAgenda;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Agendas.NovaAgenda
{
    public class NovaAgendaAdapter : INovaAgendaAdapter
    {
        private readonly INovaAgendaUseCase _useCase;

        public NovaAgendaAdapter(INovaAgendaUseCase useCase)
        {
            _useCase = useCase;
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(NovaAgendaResponse))]
        public async Task<NovaAgendaResponse> Inserir(NovaAgendaRequest agendaRequest)
        {
            var model = new AgendaModel(await _useCase.Execute(agendaRequest.DataAgenda, agendaRequest.MedicoId, agendaRequest.Horarios));

            return new NovaAgendaResponse(model);
        }
    }
}

