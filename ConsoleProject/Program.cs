// See https://aka.ms/new-console-template for more information
using ComponenteNegocio;
using ComponenteNegocio.Data;
using ConsoleProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modelo.Componentes;

ServiceCollection service = new ServiceCollection();
var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);

IConfiguration? config = builder.Build();

service.AddScoped<IComponenteNegocioUsuario, ComponenteNegocioUsuario>();
service.AddEntityFrameworkSqlServer()
              .AddDbContext<BancoContext>(o => o.UseSqlServer(config.GetConnectionString("DataBase")));


Setup.Iniciar();