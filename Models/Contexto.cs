using Microsoft.EntityFrameworkCore;
using miguel.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miguel.Models.Consulta;

namespace miguel.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }
        public DbSet<Custo> Custos { get; set; }
        public DbSet<Ordem> Ordens { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<EstoqueOrdem> EstoqueOrdens { get; set; }
        public DbSet<miguel.Models.Consulta.itens> itens { get; set; }


    }
}
