using FourSix.Domain.Entities.MedicoAggregate;

namespace FourSix.Domain.Entities.AgendaAggregate
{
    public class Agenda : BaseEntity, IAggregateRoot, IBaseEntity
    {
        private readonly List<AgendaHorario> _horarios = new();

        public Agenda() { }

        public Agenda(Guid id, DateTime dataAgenda, Guid? medicoId)
        {
            Id = id;
            DataAgenda = dataAgenda;
            MedicoId = medicoId;
        }

        public Guid? MedicoId { get; }
        public DateTime DataAgenda { get; }
        public Medico Medico { get; set; }
        public IReadOnlyCollection<AgendaHorario> Horarios => _horarios;
    }
}
