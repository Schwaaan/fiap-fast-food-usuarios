namespace FourSix.Domain.Entities.AgendaAggregate
{
    public class AgendaHorario
    {
        public AgendaHorario() { }
        public AgendaHorario(Guid agendaId, DateTime horaInicio, DateTime horaFim, string status)
        {
            AgendaId = agendaId;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Status = status;
        }

        public Guid AgendaId { get; }
        public DateTime HoraInicio { get; }
        public DateTime HoraFim { get; }
        public string Status { get; }
    }
}
