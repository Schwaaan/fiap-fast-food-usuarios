using FourSix.Domain.Entities.AgendaAggregate;

namespace FourSix.UseCases.UseCases.Agendas.NovaAgenda
{
    public interface INovaAgendaUseCase
    {
        /// <summary>
        /// Executa o Caso de Uso
        /// </summary>
        Task<Agenda> Execute(DateTime dataAgenda, Guid medicoId);
    }
}
