using FourSix.Domain.Entities.MedicoAggregate;
using FourSix.Domain.Entities.PacienteAggregate;

namespace FourSix.UseCases.Interfaces
{
    public interface IPacienteRepository : IGetRepository<Paciente>, ISetRepository<Paciente>
    {
    }
}
