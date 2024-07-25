using FourSix.Domain.Entities.MedicoAggregate;
using FourSix.Domain.Entities.PacienteAggregate;
using FourSix.Domain.Entities.AgendaAggregate;
using Microsoft.EntityFrameworkCore;

namespace FourSix.Controllers.Gateways.DataAccess
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            #region POPULA Pessoas

            builder.Entity<Medico>()
              .HasData(
               new
               {
                   Id = new Guid("FDD632FF-6852-4E89-9A1A-B8C16FB54B8B"),
                   Crm = "1234",
                   Nome = "Dr. Jorge Mendoza",
                   Especialidade = "Pediatra"
               });

            builder.Entity<Paciente>()
              .HasData(
               new
               {
                   Id = new Guid("717B2FB9-4BBE-4A8C-8574-7808CD652E0B"),
                   Cpf = "12851671049",
                   Nome = "João da Silva Gomes",
                   Email = "joao.silva@gmail.com"
               });

            #endregion



            #region POPULA Agenda
            builder.Entity<Agenda>()
              .HasData(
               new
               {
                   Id = new Guid("78E3B8D0-BE9A-4407-9304-C61788797808"),
                   MedicoId = new Guid("FDD632FF-6852-4E89-9A1A-B8C16FB54B8B"),
                   DataAgenda = DateTime.Now.Date
               });

            #endregion
        }
    }
}
