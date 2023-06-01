using GerenciadorDespesas.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Web.Mapeamento
{
    public class TipoDespesasMap : IEntityTypeConfiguration<TipoDespesas>
    {
        public void Configure(EntityTypeBuilder<TipoDespesas> builder)
        {
            builder.HasKey(td => td.Id);
            builder.Property(td => td.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(td => td.Despesas).WithOne(td => td.TipoDespesas).HasForeignKey(td => td.TipoDespesaId);

            builder.ToTable("TipoDespesas");
        }
    }
}
