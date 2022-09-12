using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Infra.Data.Configurations
{
    internal class ExampleEntityTypeConfiguration : IEntityTypeConfiguration<Domain.ExampleAggregate.Example>
    {
        public void Configure(EntityTypeBuilder<Domain.ExampleAggregate.Example> orderConfiguration)
        {
            orderConfiguration.ToTable("Example", "dbo");

            orderConfiguration.HasKey(o => o.Id);
            orderConfiguration.Property(o => o.Id).UseIdentityColumn();
            orderConfiguration.Property(o => o.Name).IsRequired();
            orderConfiguration.Property(o => o.Age).IsRequired();
        }
    }
}
