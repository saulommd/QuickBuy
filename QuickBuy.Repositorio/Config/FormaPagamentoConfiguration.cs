using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder
               .Property(f => f.Descricao)
               .IsRequired();

            builder
               .Property(f => f.EhBoleto)
               .IsRequired();

            builder
               .Property(f => f.EhCartaoCredito)
               .IsRequired();

            builder
               .Property(f => f.EhDeposito)
               .IsRequired();

            builder
               .Property(f => f.NaoFoiDefinido)
               .IsRequired();

            builder
               .Property(f => f.Nome)
               .IsRequired()
               .HasMaxLength(50);
        }
    }
}
