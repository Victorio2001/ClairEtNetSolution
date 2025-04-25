using ClairEtNet.DataContext.EntityTypesConfiguration;
using ClairEtNet.DataContext.SeedData;
using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;


namespace ClairEtNet.DataContext;

public class CnErpContext : DbContext
{
    protected CnErpContext()
    {
        
    }

    public CnErpContext(DbContextOptions<CnErpContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
            
        //!Conf Entity Ici
        modelBuilder.ApplyConfiguration(new CategorieEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AffectationEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ChantierEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ContactEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EmployerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new IncidentEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new MouvementStockEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new StockEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new UtilisateurEntityTypeConfiguration());
        //!Conf Entity Ici

        //! mettre ici les seeedata
        SeedDataCategorie.SeedDatabase(modelBuilder);
        //! mettre ici les seeedata
    }
    //! Déclaration des tables
    public DbSet<Affectation> Affectations { get; set; }
    public DbSet<Categorie> Categories { get; set; }
    public DbSet<Chantier> Chantiers { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Incident> Incidents { get; set; }
    public DbSet<MouvementStock> MouvementStocks { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Utilisateur> Utilisateurs { get; set; }

    //! Déclaration des tables
    
}
