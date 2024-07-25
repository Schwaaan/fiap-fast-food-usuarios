using FourSix.Controllers.ViewModels;

namespace FourSix.Controllers.Adapters.Agendas.NovaAgenda
{
    public class NovaAgendaResponse
    {
        public NovaAgendaResponse(AgendaModel agendaModel) => Agenda = agendaModel;
        public AgendaModel Agenda { get; }
    }
}
