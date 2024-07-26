using FourSix.Domain.Entities.AgendaAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FourSix.Controllers.Gateways.Configurations
{
    public class AgendaHorarioConfiguration : IEntityTypeConfiguration<AgendaHorario>
    {

        public void Configure(EntityTypeBuilder<AgendaHorario> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("AgendaHorario");
            builder.HasKey(e => new { e.AgendaId, e.HoraInicio });

            builder.Property(b => b.AgendaId)
                .IsRequired()
                .ValueGeneratedNever()
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.HoraInicio)
                .IsRequired()
                .ValueGeneratedNever()
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.HoraFim)
                .IsRequired()
                .ValueGeneratedNever()
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Status)
                .IsRequired()
                .ValueGeneratedNever()
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
        }
    }
}
