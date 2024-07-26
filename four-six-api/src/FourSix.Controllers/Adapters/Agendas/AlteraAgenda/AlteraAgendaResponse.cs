using FourSix.Controllers.ViewModels;

namespace FourSix.Controllers.Adapters.Agendas.AlteraAgenda
{
    public class AlteraAgendaResponse
    {
        public AlteraAgendaResponse(AgendaModel agendaModel) => Agenda = agendaModel;
        public AgendaModel Agenda { get; }
    }
}
