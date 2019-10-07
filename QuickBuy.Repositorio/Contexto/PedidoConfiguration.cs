using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Entidades.Dominio;

namespace QuickBuy.Repositorio.Contexto
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevistaEntrega)
                .IsRequired();

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired();

            builder.Ignore(p => p._mensagemValidacao);

            builder.HasOne(p => p.Usuario);

            builder.HasOne(p => p.FormaPagamento);

            builder
                .HasMany(u => u.ItensPedido)
                .WithOne(p => p.Pedido);
        }
    }
}