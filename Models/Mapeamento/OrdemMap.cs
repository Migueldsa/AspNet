using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using miguel.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Mapeamento
{

    public class OrdemMap : IEntityTypeConfiguration<Ordem>
    {

        public void Configure(EntityTypeBuilder<Ordem> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.proprietario).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();
            builder.Property(p => p.endereco).HasMaxLength(35).IsRequired();
            builder.Property(p => p.defeito).HasMaxLength(150).IsRequired();

  


    }
    }
}
