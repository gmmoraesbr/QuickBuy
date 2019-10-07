using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Entidades.Dominio;

namespace QuickBuy.Repositorio.Contexto
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("ItemPedido");

            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            builder.HasOne(i => i.Produto);

            builder.HasOne(i => i.Pedido);

            builder.Ignore(i => i._mensagemValidacao);
        }
    }
}