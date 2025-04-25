using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class CategorieEntityTypeConfiguration : IEntityTypeConfiguration<Categorie>
{
    public void Configure(EntityTypeBuilder<Categorie> builder)
    {
        builder.HasKey(e => e.Id_categorie);

        builder.HasMany(e => e.Stocks)
            .WithOne(s => s.Categorie)
            .HasForeignKey(s => s.Id_categorie)
            .OnDelete(DeleteBehavior.Cascade);
    }
}