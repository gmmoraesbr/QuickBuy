using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Entidades.Dominio;

namespace QuickBuy.Repositorio.Contexto
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(p => p.Preco)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder
                .HasMany(u => u.ItensPedido)
                .WithOne(p => p.Produto);

            builder.Ignore(p => p._mensagemValidacao);
        }
    }
}