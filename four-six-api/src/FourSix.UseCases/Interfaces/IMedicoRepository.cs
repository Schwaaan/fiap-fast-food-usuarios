using FourSix.Domain.Entities.MedicoAggregate;

namespace FourSix.UseCases.Interfaces
{
    public interface IMedicoRepository : IGetRepository<Medico>, ISetRepository<Medico>
    {
    }
}
