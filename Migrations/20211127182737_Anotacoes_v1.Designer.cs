﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using miguel.Models;

namespace miguel.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211127182737_Anotacoes_v1")]
    partial class Anotacoes_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("miguel.Models.Dominio.Custo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mobra")
                        .HasMaxLength(35)
                        .HasColumnType("int");

                    b.Property<string>("problema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.Property<string>("vfornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Custo");
                });

            modelBuilder.Entity("miguel.Models.Dominio.Estoque", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("miguel.Models.Dominio.EstoqueOrdem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("estoqueid")
                        .HasColumnType("int");

                    b.Property<int?>("ordemid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("estoqueid");

                    b.HasIndex("ordemid");

                    b.ToTable("EstoqueOrdens");
                });

            modelBuilder.Entity("miguel.Models.Dominio.Ordem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("defeito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("valorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("valorid");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("miguel.Models.Dominio.EstoqueOrdem", b =>
                {
                    b.HasOne("miguel.Models.Dominio.Estoque", "estoque")
                        .WithMany()
                        .HasForeignKey("estoqueid");

                    b.HasOne("miguel.Models.Dominio.Ordem", "ordem")
                        .WithMany()
                        .HasForeignKey("ordemid");

                    b.Navigation("estoque");

                    b.Navigation("ordem");
                });

            modelBuilder.Entity("miguel.Models.Dominio.Ordem", b =>
                {
                    b.HasOne("miguel.Models.Dominio.Custo", "valor")
                        .WithMany()
                        .HasForeignKey("valorid");

                    b.Navigation("valor");
                });
#pragma warning restore 612, 618
        }
    }
}