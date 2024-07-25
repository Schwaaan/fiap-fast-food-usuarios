using FourSix.Domain.Entities.AgendaAggregate;

namespace FourSix.UseCases.Interfaces
{
    public interface IAgendaHorarioRepository : IGetRepository<AgendaHorario, string>, ISetRepository<AgendaHorario, string>
    {
    }
}
