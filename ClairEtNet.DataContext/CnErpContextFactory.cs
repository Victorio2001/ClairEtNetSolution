using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ClairEtNet.DataContext;

public class CnErpContextFactory : IDesignTimeDbContextFactory<CnErpContext>
{
    public CnErpContext CreateDbContext(string[] args)
    {
        //! Récupération de la configuration 
        var configurationBuilder = new ConfigurationBuilder();
        configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        var configuration = configurationBuilder.Build();

            
        //! Création du contexte en lui passabt la configuration
        DbContextOptionsBuilder<CnErpContext> builder = new DbContextOptionsBuilder<CnErpContext>();
            
            
        //! Récupération de la chaine de configuration dans le fichier de configuration
        builder.UseSqlServer(configuration.GetConnectionString("CnErpContext"));
            
        return new CnErpContext(builder.Options);
    }
}


