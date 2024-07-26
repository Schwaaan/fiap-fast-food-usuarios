using FourSix.Domain.Entities.AgendaAggregate;

namespace FourSix.UseCases.UseCases.Agendas.AlteraAgenda
{
    public interface IAlteraAgendaUseCase
    {
        /// <summary>
        /// Executa o Caso de Uso
        /// </summary>
        Task<Agenda> Execute(Guid id, DateTime dataAgenda, ICollection<Tuple<DateTime, DateTime>> horarios);
    }
}
