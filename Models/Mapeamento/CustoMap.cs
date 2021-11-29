using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using miguel.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Mapeamento
{
    public class CustoMap : IEntityTypeConfiguration<Custo>
    {
        public void Configure(EntityTypeBuilder<Custo> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.mobra).HasMaxLength(35).IsRequired();
            builder.Property(p => p.vfornecedor).HasMaxLength(35).IsRequired();
            builder.Property(p => p.problema).HasMaxLength(50).IsRequired();

        }
    }
}
