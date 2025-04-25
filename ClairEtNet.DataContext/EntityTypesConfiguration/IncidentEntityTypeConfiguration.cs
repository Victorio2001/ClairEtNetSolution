using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class IncidentEntityTypeConfiguration : IEntityTypeConfiguration<Incident>
{
    public void Configure(EntityTypeBuilder<Incident> builder)
    {
        builder.HasKey(e => e.Id_incident);

        builder.HasOne(e => e.Chantier)
            .WithMany(c => c.Incidents)
            .HasForeignKey(e => e.Id_chantier)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Employer)
            .WithMany(emp => emp.Incidents)
            .HasForeignKey(e => e.Id_employer)
            .OnDelete(DeleteBehavior.Cascade);
    }
}