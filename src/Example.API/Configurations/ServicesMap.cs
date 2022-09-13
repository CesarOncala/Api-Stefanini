using Example.Application.CidadeService.Service;
using Example.Application.ExampleService.Service;
using Example.Application.PessoaService.Service;
using Example.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Configurations
{
    public static class ServicesMap
    {
        static void EntityServices(IServiceCollection services)
        {
            services.AddScoped<IExampleService, ExampleService>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<ICidadeService, CidadeService>();
        }

        public static void Services(IServiceCollection services, IConfiguration config)
        {
            EntityServices(services);

            // Add services to the container.

            services.AddControllers()
                .AddNewtonsoftJson(o=> o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<ExampleContext>(o => o.
            UseSqlServer(config.GetConnectionString("DefaultConnection")));
        }
    }
}
