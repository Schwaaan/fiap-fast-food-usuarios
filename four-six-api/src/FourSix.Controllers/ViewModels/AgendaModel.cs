using FourSix.Domain.Entities.AgendaAggregate;

namespace FourSix.Controllers.ViewModels
{
    public class AgendaModel
    {
        public AgendaModel(Agenda agenda)
        {
            Id = agenda.Id;
            DataAgenda = agenda.DataAgenda;
            MedicoId = agenda.MedicoId;
        }

        public Guid Id { get; }
        public Guid? MedicoId { get; }
        public DateTime DataAgenda { get; }
        public List<AgendaHorarioModel> Horarios { get; private set; }
        public void AdicionarItem(string hora, string status)
        {
            Horarios.Add(new AgendaHorarioModel(hora, status));
        }

    }
}
