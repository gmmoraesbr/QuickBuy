using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Contexto
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.ToTable("FormaPagamento");

            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}