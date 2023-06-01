using GerenciadorDespesas.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Web.Mapeamento
{
    public class MesesMap : IEntityTypeConfiguration<Meses>
    {
        public void Configure(EntityTypeBuilder<Meses> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedNever();
            builder.Property(m => m.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(m => m.Despesas).WithOne(m => m.Meses).HasForeignKey(m => m.MesId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(m => m.Salarios).WithOne(m => m.Meses).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Meses");
        }
    }
}
