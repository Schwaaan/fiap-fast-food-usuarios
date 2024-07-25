using FourSix.Domain.Entities.AgendaAggregate;
using FourSix.UseCases.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourSix.Controllers.Gateways.Repositories
{
    public class AgendaHorarioRepository : BaseRepository<AgendaHorario, string>, IAgendaHorarioRepository
    {
        public AgendaHorarioRepository(DbContext context) : base(context)
        {
        }
    }
}
