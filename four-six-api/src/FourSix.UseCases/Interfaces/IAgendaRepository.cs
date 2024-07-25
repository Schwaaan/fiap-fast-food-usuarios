using FourSix.Domain.Entities.AgendaAggregate;

namespace FourSix.UseCases.Interfaces
{
    public interface IAgendaRepository : IGetRepository<Agenda>, ISetRepository<Agenda>
    {
    }
}
