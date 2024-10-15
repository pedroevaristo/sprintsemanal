using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using mvc.Models;

public class Startup//aqui segundo as pesquisas é apra inicializa o banco de dados mas não sei ao certo, mas vou deixar as informações de artigos que ja connecta com o banco de dados
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.Configure<SettingsDB>(
            Configuration.GetSection(nameof(SettingsDB)));

        services.AddSingleton<SettingsDB>(sp =>
            sp.GetRequiredService<IOptions<SettingsDB>>().Value);

        services.AddSingleton<IMongoClient, MongoClient>(sp =>
            new MongoClient(Configuration.GetConnectionString("MongoDb")));

        services.AddScoped<IMongoDatabase>(sp =>
            sp.GetRequiredService<IMongoClient>().GetDatabase(
                Configuration.GetSection("SettingsDB:DatabaseName").Value));

        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configurações do pipeline de requisição HTTP
    }
}