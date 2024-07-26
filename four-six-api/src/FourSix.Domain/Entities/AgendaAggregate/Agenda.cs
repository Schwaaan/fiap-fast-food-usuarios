using FourSix.Domain.Entities.MedicoAggregate;

namespace FourSix.Domain.Entities.AgendaAggregate
{
    public class Agenda : BaseEntity, IAggregateRoot, IBaseEntity
    {
        public Agenda() { }

        public Agenda(Guid id, DateTime dataAgenda, Guid? medicoId, ICollection<AgendaHorario> horarios)
        {
            Id = id;
            DataAgenda = dataAgenda;
            MedicoId = medicoId;
            Horarios = horarios;
        }

        public Guid? MedicoId { get; }
        public DateTime DataAgenda { get; }
        public Medico Medico { get; }
        public ICollection<AgendaHorario> Horarios { get; }
    }
}
