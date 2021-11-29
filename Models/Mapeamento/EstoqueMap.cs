using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using miguel.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Mapeamento
{
    public class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.descricao).HasMaxLength(50).IsRequired();
            builder.Property(p => p.quantidade).HasMaxLength(35).IsRequired();
            builder.Property(p => p.valor).HasMaxLength(4).IsRequired();

        }
    }
}
