using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class ChantierEntityTypeConfiguration : IEntityTypeConfiguration<Chantier>
{
    public void Configure(EntityTypeBuilder<Chantier> builder)
    {
        builder.HasKey(e => e.Id_chantier);

        builder.HasMany(e => e.MouvementsStock)
            .WithOne(ms => ms.Chantier)
            .HasForeignKey(ms => ms.Id_chantier)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Incidents)
            .WithOne(i => i.Chantier)
            .HasForeignKey(i => i.Id_chantier)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Affectations)
            .WithOne(a => a.Chantier)
            .HasForeignKey(a => a.Id_chantier)
            .OnDelete(DeleteBehavior.Cascade);
    }
}