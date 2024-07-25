namespace FourSix.Domain.Entities.MedicoAggregate
{
    public class Medico : BaseEntity, IAggregateRoot, IBaseEntity
    {
        public Medico(){}    
        public Medico(Guid id, string crm, string nome, string especialidade)
        {
            this.Id = id;
            this.Crm = crm;
            this.Nome = nome;
            this.Especialidade = especialidade;
        }
        public string Crm { get; }
        public string Nome { get; }
        public string Especialidade { get; }
    }
}
