using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class UtilisateurEntityTypeConfiguration : IEntityTypeConfiguration<Utilisateur>
{
    public void Configure(EntityTypeBuilder<Utilisateur> builder)
    {
        builder.HasKey(e => e.Id_utilisateur);

        /*builder.HasOne(e => e.Role)
            .WithMany(r => r.Utilisateurs)
            .HasForeignKey(e => e.Id_role)
            .OnDelete(DeleteBehavior.Restrict);*/

        builder.HasMany(e => e.MouvementsStock)
            .WithOne(ms => ms.Utilisateur)
            .HasForeignKey(ms => ms.Id_utilisateur)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Employer)
            .WithOne(emp => emp.Utilisateur)
            .HasForeignKey<Employer>(emp => emp.Id_utilisateur)
            .OnDelete(DeleteBehavior.Cascade);
    }
}