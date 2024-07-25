using FourSix.Domain.Entities.PacienteAggregate;

namespace FourSix.Controllers.ViewModels
{
    public class PacienteModel
    {
        public PacienteModel(Paciente cliente)
        {
            Id = cliente.Id;
            Cpf = cliente.Cpf;
            Nome = cliente.Nome;
            Email = cliente.Email;
        }
        public Guid Id { get; }
        public string Cpf { get; }
        public string Nome { get; }
        public string Email { get; }
    }
}
