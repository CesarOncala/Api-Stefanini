using Example.Domain.CidadeAggregate;
using Example.Domain.PessoaAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Infra.Data.Configurations
{

    internal class PessoaEntityTypeConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> orderConfiguration)
        {
            orderConfiguration.ToTable("Pessoa", "dbo");

            orderConfiguration.HasKey(o => o.Id);
            orderConfiguration.Property(o => o.Id).UseIdentityColumn();

            orderConfiguration.Property(o => o.Nome)
                .IsRequired()
                .HasMaxLength(300);

            orderConfiguration.Property(o => o.CPF)
                .IsRequired();

            orderConfiguration.HasOne(o=> o.Cidade)
               .WithMany(o => o.Pessoas)
               .HasForeignKey(o => o.Id_Cidade)
               .IsRequired();

        }
    }

}
