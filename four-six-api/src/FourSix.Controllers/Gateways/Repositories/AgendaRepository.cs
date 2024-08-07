﻿using FourSix.Domain.Entities.AgendaAggregate;
using FourSix.UseCases.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FourSix.Controllers.Gateways.Repositories
{
    public class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        public AgendaRepository(DbContext context) : base(context)
        {
        }

        public override IEnumerable<Agenda> Listar(Expression<Func<Agenda, bool>>? predicate = null)
        {
            var agendas = _context.Set<Agenda>().Include(i => i.Horarios).Include(i => i.Horarios);

            if (predicate == null)
                return agendas.AsNoTracking();
            else
                return agendas.Where(predicate).AsNoTracking();
        }
    }
}
