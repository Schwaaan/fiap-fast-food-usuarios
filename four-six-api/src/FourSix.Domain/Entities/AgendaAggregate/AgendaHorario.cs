namespace FourSix.Domain.Entities.AgendaAggregate
{
    public class AgendaHorario
    {
        public AgendaHorario() { }
        public AgendaHorario(Guid agendaId, string hora, string status)
        {
            AgendaId = agendaId;
            Hora = hora;
            Status = status;
        }

        public Guid AgendaId { get; }
        public string Hora { get; }
        public string Status { get; }
    }
}
