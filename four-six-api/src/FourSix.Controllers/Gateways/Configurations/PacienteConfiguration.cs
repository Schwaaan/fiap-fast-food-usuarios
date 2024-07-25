using FourSix.Domain.Entities.PacienteAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FourSix.Controllers.Gateways.Configurations
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {

        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("Paciente");
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            builder.Property(b => b.Email)
            .IsRequired()
            .HasMaxLength(100)
            .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

        }
    }
}
