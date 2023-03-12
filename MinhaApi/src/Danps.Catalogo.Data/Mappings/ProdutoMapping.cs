using Danps.Catalogo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Danps.Catalogo.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(t => t.Id).HasColumnName("seq_my_produto");
            builder.Property(t => t.FornecedorId).HasColumnName("seq_my_fornecedor");
            builder.Property(p => p.Nome).HasColumnName("nom_produto").IsRequired().HasColumnType("varchar(255)");
            builder.Property(p => p.Descricao).HasColumnName("dsc_produto").IsRequired().HasColumnType("varchar(1000)");
            builder.Property(p => p.Valor).HasColumnName("val_produto").IsRequired().HasColumnType("varchar(1000)");
            builder.Property(p => p.Imagem).HasColumnName("dsc_imagem").IsRequired().HasColumnType("varchar(127)");
            builder.Property(p => p.Ativo).HasColumnName("ind_ativo").IsRequired(); 
            builder.Property(t => t.DataCadastro).HasColumnName("dat_inclusao").HasColumnType("datetime"); 
            builder.ToTable("my_produto");
        }
    }
}