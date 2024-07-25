using FourSix.Domain.Entities.MedicoAggregate;

namespace FourSix.UseCases.UseCases.Medicos.ObtemMedico
{
    public interface IObtemMedicoUseCase
    {
        Task<Medico> Execute(string cpf);
    }
}
