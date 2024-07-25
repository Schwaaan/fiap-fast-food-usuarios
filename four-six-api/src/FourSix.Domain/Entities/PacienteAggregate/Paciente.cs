namespace FourSix.Domain.Entities.PacienteAggregate
{
    public class Paciente : BaseEntity, IAggregateRoot, IBaseEntity
    {
        public Paciente() { }
        public Paciente(Guid id, string cpf, string nome, string email)
        {
            this.Id = id;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Email = email;
        }
        public string Cpf { get; }
        public string Nome { get; }
        public string Email { get; }
    }
}