using System.Globalization;
using ClairEtNet.DataContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

namespace ClairEtNet.Web.Config;


public static class ServicesExtensionMethods
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration,  IWebHostEnvironment env)
    {
        /*services.AddScoped<IReservationRepository, ReservationRepository>();
        services.AddScoped<IEventDataSource, EventDataSource>();
        services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
        services.AddScoped<IEtapeRepository, EtapeRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IPhotoRepository, PhotoRepository>();
        services.AddEndpointsApiExplorer(); 
        
        services.AddHealthChecks();
        services.Configure<StripeSettings>(configuration.GetSection("Stripe"));*/
        
        
        //!--------------------------------------------- Identity
        
        /*services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            })
            .AddEntityFrameworkStores<SolutionDaisyKorpContext>()
            .AddDefaultTokenProviders();
 
        services.AddScoped<UserManager<ApplicationUser>>();
        services.AddScoped<RoleManager<IdentityRole>>();*/
        
        //!--------------------------------------------- Identity
        
        
        
        //!--------------------------------------------- Application Classe Env 
        
        /*if (env.IsDevelopment())
        {
            Env.Load();
        }*/
        
        //? 1: Key 2:Default
        var server = Env.Get("DB_SERVER", "localhost,1433");
        //? 1: Key 2:Default
        var dbName = Env.Get("DB_NAME", "CnErpDb");
        //? 1: Key 2:Default //! Trusted Certificat
        var Trusted = Env.Get("DB_TRUSTED", "True");
        //? 1: Key 2:Default
        var Intent = Env.Get("DB_INTENT", "ReadWrite");
        //? 1: Key 2:Default
        var Encrypt = Env.Get("DB_Encrypt", "False");
        
        //! DB_USERNAME=null
        //! DB_PASSWORD=null
        
        //? 1: Key 2:Default
        var USER = Env.Get("DB_USERNAME", "sa");
        //? 1: Key 2:Default
        var PASWWORD = Env.Get("DB_PASSWORD", "");
        
        var defaultConnString = configuration.GetConnectionString("CnErpContext"); 
        
        //? Rebuild de ma chaine de connection
        var newConnString = defaultConnString
            .Replace("Server=localhost", $"Server={server}")
            .Replace("Database=SolutionDaisyKorpDB", $"Database={dbName}")
            .Replace("Trusted_Connection=True", $"Trusted_Connection={Trusted}")
            .Replace("Encrypt=False", $"Encrypt={Encrypt}")
            .Replace("ApplicationIntent=ReadWrite", $"ApplicationIntent={Intent}")
            .Replace("Password=", $"Password={PASWWORD}");
     //       .Replace("User Id=", $"User Id={USER}");
        
        configuration["ConnectionStrings:CnErpContext"] = newConnString;

        Console.WriteLine($"Chaine de connection: {newConnString}");
        Console.WriteLine($"Chaine de connection: {newConnString}");
        Console.WriteLine($"Chaine de connection: {newConnString}");
        
        
        //!--------------------------------------------- Application Classe Env 
        
        
        
        //!--------------------------------------------- ReWork sys Routingg
        services.Configure<RazorViewEngineOptions>(options =>
        {
            options.ViewLocationFormats.Clear();
            //! 2 -> Areas
            //! 1 -> Controllers
            //! 0 --> Action
            //?%arche mais que pour les views racine
            options.ViewLocationFormats.Add($"/Views/Shared/Components/{{0}}"+ RazorViewEngine.ViewExtension);
            //?Spécifique au raeass
            options.AreaViewLocationFormats.Add($"/Views/Shared/Components/{{0}}"+ RazorViewEngine.ViewExtension);
            //? plus besoin de sous directory pour mes areas
            options.AreaViewLocationFormats.Add($"/Areas/{{1}}/Views/{{0}}"+ RazorViewEngine.ViewExtension);
    
            //!Supp quand full areas
            options.ViewLocationFormats.Add($"/Views/{{1}}/{{0}}"+ RazorViewEngine.ViewExtension);
        });
        //!--------------------------------------------- ReWork sys Routingg
        
        
        
        //!--------------------------------------------- Localisation du dossier Resources
        services.AddControllersWithViews()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix); //! en; fr; es; etc.
        
        
        services.AddLocalization(options => options.ResourcesPath = "Resources");
        services.Configure<RequestLocalizationOptions>(options =>
        {
            //? nos langages supportés
            var supportedCutures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("fr-FR")
            };
            //! langue par default
            options.DefaultRequestCulture = new RequestCulture("fr-FR");
            options.SupportedCultures = supportedCutures;
            options.SupportedUICultures = supportedCutures;
            
            options.RequestCultureProviders.Insert(0, new CookieRequestCultureProvider());

        });

        //!--------------------------------------------- Localisation du dossier Resources
        
        
        
        //!--------------------------------------------- Voip
        
        /*services.AddSingleton<IVoipService, VoipService>();
        services.AddHostedService<VoipBackgroundService>();*/
        
        //!--------------------------------------------- Voip

        string connectionString = configuration.GetConnectionString("CnErpContext");
        services.AddDbContext<CnErpContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
            
        return services;
    }
    
}