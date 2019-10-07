using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Entidades.Dominio;

namespace QuickBuy.Repositorio.Contexto
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);

            builder.Ignore(p => p._mensagemValidacao);
        }
    }
}