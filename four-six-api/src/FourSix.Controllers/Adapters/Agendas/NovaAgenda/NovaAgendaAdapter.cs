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
        public async Task<NovaAgendaResponse> Inserir(NovaAgendaRequest pedido)
        {
            var model = new AgendaModel(await _useCase.Execute(pedido.DataAgenda, pedido.MedicoId));

            return new NovaAgendaResponse(model);
        }
    }
}

