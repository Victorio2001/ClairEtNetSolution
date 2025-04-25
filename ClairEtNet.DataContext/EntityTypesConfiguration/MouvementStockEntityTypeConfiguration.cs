using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class MouvementStockEntityTypeConfiguration : IEntityTypeConfiguration<MouvementStock>
{
    public void Configure(EntityTypeBuilder<MouvementStock> builder)
    {
        builder.HasKey(e => e.Id_mouvementstock);

        builder.HasOne(e => e.Stock)
            .WithMany(s => s.MouvementsStock)
            .HasForeignKey(e => e.Id_stock)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Utilisateur)
            .WithMany(u => u.MouvementsStock)
            .HasForeignKey(e => e.Id_utilisateur)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Chantier)
            .WithMany(c => c.MouvementsStock)
            .HasForeignKey(e => e.Id_chantier)
            .OnDelete(DeleteBehavior.Cascade);
    }
}