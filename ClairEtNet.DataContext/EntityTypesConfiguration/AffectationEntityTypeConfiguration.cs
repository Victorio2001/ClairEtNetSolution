using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class AffectationEntityTypeConfiguration : IEntityTypeConfiguration<Affectation>
{
    public void Configure(EntityTypeBuilder<Affectation> builder)
    {
        builder.HasKey(e => e.Id_affectation);

        builder.HasOne(e => e.Employer)
            .WithMany(emp => emp.Affectations)
            .HasForeignKey(e => e.Id_employer)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Chantier)
            .WithMany(ch => ch.Affectations)
            .HasForeignKey(e => e.Id_chantier)
            .OnDelete(DeleteBehavior.Cascade);
    }
}