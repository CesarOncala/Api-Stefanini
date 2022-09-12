using Example.Domain.CidadeAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Infra.Data.Configurations
{
    internal class CidadeEntityTypeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> orderConfiguration)
        {
            orderConfiguration.ToTable("Cidade", "dbo");

            orderConfiguration.HasKey(o => o.Id);
            orderConfiguration.Property(o => o.Id).UseIdentityColumn();

            orderConfiguration.Property(o => o.Nome)
                .IsRequired()
                .HasMaxLength(200);

            orderConfiguration.Property(o => o.UF)
                .IsRequired()
                .HasMaxLength(2);

        }
    }
}
