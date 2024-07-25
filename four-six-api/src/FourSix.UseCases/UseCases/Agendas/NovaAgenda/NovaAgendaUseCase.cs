using FourSix.Domain.Entities.AgendaAggregate;
using FourSix.Domain.Entities.MedicoAggregate;
using FourSix.UseCases.Interfaces;

namespace FourSix.UseCases.UseCases.Agendas.NovaAgenda
{
    public class NovaAgendaUseCase : INovaAgendaUseCase
    {
        private readonly IAgendaRepository _agendaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public NovaAgendaUseCase(
            IAgendaRepository agendaRepository,
            IUnitOfWork unitOfWork)
        {
            _agendaRepository = agendaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Agenda> Execute(DateTime dataAgenda, Guid medicoId)
        {
            var id = Guid.NewGuid();

            var pedido = await InserirAgenda(
                new Agenda(id,
                dataAgenda,
                medicoId));
            return pedido;
        }

        private async Task<Agenda> InserirAgenda(Agenda agenda)
        {
            await _agendaRepository
                 .Incluir(agenda)
                 .ConfigureAwait(false);

            await _unitOfWork
                .Save()
                .ConfigureAwait(false);

            return agenda;
        }
    }
}
