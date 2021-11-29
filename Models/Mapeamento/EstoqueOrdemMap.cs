using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using miguel.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Mapeamento
{
    public class EstoqueOrdemMap : IEntityTypeConfiguration<EstoqueOrdem>
    {
        public void Configure(EntityTypeBuilder<EstoqueOrdem> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.ordem).HasMaxLength(35).IsRequired();
            builder.Property(p => p.estoque).HasMaxLength(10).IsRequired();
        }
    }
}
