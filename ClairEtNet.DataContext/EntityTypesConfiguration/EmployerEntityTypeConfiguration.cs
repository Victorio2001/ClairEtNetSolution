using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class EmployerEntityTypeConfiguration : IEntityTypeConfiguration<Employer>
{
    public void Configure(EntityTypeBuilder<Employer> builder)
    {
        builder.HasKey(e => e.Id_employer);

        builder.HasOne(e => e.Utilisateur)
            .WithOne(u => u.Employer)
            .HasForeignKey<Employer>(e => e.Id_utilisateur)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Affectations)
            .WithOne(a => a.Employer)
            .HasForeignKey(a => a.Id_employer)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Incidents)
            .WithOne(i => i.Employer)
            .HasForeignKey(i => i.Id_employer)
            .OnDelete(DeleteBehavior.Cascade);
    }
}