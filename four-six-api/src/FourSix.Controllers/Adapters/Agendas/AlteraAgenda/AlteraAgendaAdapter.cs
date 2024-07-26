using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Agendas.AlteraAgenda;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Agendas.AlteraAgenda
{
    public class AlteraAgendaAdapter : IAlteraAgendaAdapter
    {
        private readonly IAlteraAgendaUseCase _useCase;

        public AlteraAgendaAdapter(IAlteraAgendaUseCase useCase)
        {
            _useCase = useCase;
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AlteraAgendaResponse))]
        public async Task<AlteraAgendaResponse> Alterar(Guid id, AlteraAgendaRequest agenda)
        {
            var model = new AgendaModel(await _useCase.Execute(id, agenda.DataAgenda, agenda.Horarios));

            return new AlteraAgendaResponse(model);
        }
    }
}

