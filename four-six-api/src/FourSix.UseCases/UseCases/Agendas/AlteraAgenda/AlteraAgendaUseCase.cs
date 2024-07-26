using FourSix.Domain.Entities.AgendaAggregate;
using FourSix.UseCases.Interfaces;

namespace FourSix.UseCases.UseCases.Agendas.AlteraAgenda
{
    public class AlteraAgendaUseCase : IAlteraAgendaUseCase
    {
        private readonly IAgendaRepository _agendaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AlteraAgendaUseCase(
            IAgendaRepository agendaRepository,
            IUnitOfWork unitOfWork)
        {
            _agendaRepository = agendaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Agenda> Execute(Guid id, DateTime dataAgenda, ICollection<Tuple<DateTime, DateTime>> horarios)
        {
            var agendaAtual = _agendaRepository.Obter(id);

            var agenda = await AlterarAgenda(
                new Agenda(id,
                    dataAgenda,
                    agendaAtual.MedicoId,
                    horarios.Select(s => new AgendaHorario(id, s.Item1, s.Item2, "OK")).ToList()));
            return agenda;
        }

        private async Task<Agenda> AlterarAgenda(Agenda agenda)
        {
            await _agendaRepository
                 .Alterar(agenda)
                 .ConfigureAwait(false);

            await _unitOfWork
                .Save()
                .ConfigureAwait(false);

            return agenda;
        }
    }
}
