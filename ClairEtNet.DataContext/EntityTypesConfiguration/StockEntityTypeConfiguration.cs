using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClairEtNet.DataContext.EntityTypesConfiguration;

public class StockEntityTypeConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasKey(e => e.Id_stock);

        builder.HasOne(e => e.Categorie)
            .WithMany(c => c.Stocks)
            .HasForeignKey(e => e.Id_categorie)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.MouvementsStock)
            .WithOne(ms => ms.Stock)
            .HasForeignKey(ms => ms.Id_stock)
            .OnDelete(DeleteBehavior.Cascade);
    }
}