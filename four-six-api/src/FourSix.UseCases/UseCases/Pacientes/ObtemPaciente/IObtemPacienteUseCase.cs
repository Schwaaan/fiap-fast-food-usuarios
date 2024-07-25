using FourSix.Domain.Entities.PacienteAggregate;

namespace FourSix.UseCases.UseCases.Pacientes.ObtemPaciente
{
    public interface IObtemPacienteUseCase
    {
        Task<Paciente> Execute(string cpf);
    }
}
