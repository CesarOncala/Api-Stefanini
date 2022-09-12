using Example.Domain;
using Example.Domain.CidadeAggregate;
using Example.Domain.PessoaAggregate;
using Example.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Infra.Data
{
    /// <summary>
    /// Referência de artigo para conseguir criar modelos de configuração
    /// https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core
    /// Rererência de artigo para conseguir criar migration a partir de dominios
    /// https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli
    /// </summary>
    public class ExampleContext : DbContext
    {
        public DbSet<Domain.ExampleAggregate.Example> Example { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public ExampleContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ExampleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CidadeEntityTypeConfiguration());

            //modelBuilder.Entity<Domain.ExampleAggregate.Example>();
            //modelBuilder.Entity<Pessoa>();
            //modelBuilder.Entity<Cidade>();

        }
    }
}
