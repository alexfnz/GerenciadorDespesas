﻿// <auto-generated />
using GerenciadorDespesas.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorDespesas.Web.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GerenciadorDespesas.Web.Models.Despesas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MesId");

                    b.Property<int>("TipoDespesaId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("MesId");

                    b.HasIndex("TipoDespesaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("GerenciadorDespesas.Web.Models.Meses", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Meses");
                });

            modelBuilder.Entity("GerenciadorDespesas.Web.Models.Salarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MesId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("MesId")
                        .IsUnique();

                    b.ToTable("Salarios");
                });

            modelBuilder.Entity("GerenciadorDespesas.Web.Models.TipoDespesas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoDespesas");
                });

            modelBuilder.Entity("GerenciadorDespesas.Web.Models.Despesas", b =>
                {
                    b.HasOne("GerenciadorDespesas.Web.Models.Meses", "Meses")
                        .WithMany("Despesas")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GerenciadorDespesas.Web.Models.TipoDespesas", "TipoDespesas")
                        .WithMany("Despesas")
                        .HasForeignKey("TipoDespesaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GerenciadorDespesas.Web.Models.Salarios", b =>
                {
                    b.HasOne("GerenciadorDespesas.Web.Models.Meses", "Meses")
                        .WithOne("Salarios")
                        .HasForeignKey("GerenciadorDespesas.Web.Models.Salarios", "MesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
