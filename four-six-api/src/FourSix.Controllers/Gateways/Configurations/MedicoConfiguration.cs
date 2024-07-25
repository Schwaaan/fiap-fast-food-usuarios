using FourSix.Domain.Entities.MedicoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FourSix.Controllers.Gateways.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {

        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("Medico");
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Crm)
                .IsRequired()
                .HasMaxLength(11)
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Especialidade)
            .IsRequired()
            .HasMaxLength(100)
            .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

        }
    }
}
