using Danps.Catalogo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Danps.Catalogo.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(t => t.Id).HasColumnName("seq_my_fornecedor");
            builder.Property(p => p.Nome).HasColumnName("nom_fornecedor").IsRequired().HasColumnType("varchar(255)");
            builder.Property(p => p.TipoFornecedor).HasColumnName("idt_tipo_fornecedor").IsRequired();
            builder.Property(p => p.Ativo).HasColumnName("ind_ativo").IsRequired();
            //builder.Property(t => t.EnderecoId).HasColumnName("seq_my_endereco");  

            builder.Property(p => p.Documento).HasColumnName("num_documento").IsRequired().HasColumnType("varchar(20)");
            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Endereco).WithOne(e => e.Fornecedor);
            // 1 : N => Fornecedor : Produtos
            builder.HasMany(f => f.Produtos).WithOne(p => p.Fornecedor).HasForeignKey(p => p.FornecedorId);
            builder.ToTable("my_fornecedor");
        }
    }
}