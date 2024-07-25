using FourSix.Domain.Entities.MedicoAggregate;

namespace FourSix.Controllers.ViewModels
{
    public class MedicoModel
    {
        public MedicoModel(Medico cliente)
        {
            Id = cliente.Id;
            Crm = cliente.Crm;
            Nome = cliente.Nome;
            Especialidade = cliente.Especialidade;
        }
        public Guid Id { get; }
        public string Crm { get; }
        public string Nome { get; }
        public string Especialidade { get; }
    }
}
