﻿using GerenciadorDespesas.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDespesas.Web.Mapeamento
{
    public class DespesasMap : IEntityTypeConfiguration<Despesas>
    {
        public void Configure(EntityTypeBuilder<Despesas> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Valor).IsRequired();

            builder.HasOne(d => d.Meses).WithMany(d => d.Despesas).HasForeignKey(d => d.MesId);
            builder.HasOne(d => d.TipoDespesas).WithMany(d => d.Despesas).HasForeignKey(d => d.TipoDespesaId);

            builder.ToTable("Despesas");
        }
    }
}