using Danps.Business.Areas.CAD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Danps.Data.Areas.CAD.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(t => t.Id).HasColumnName("seq_my_endereco");
            builder.Property(t => t.FornecedorId).HasColumnName("seq_my_fornecedor");            
            builder.Property(c => c.Logradouro).HasColumnName("logradouro").IsRequired().HasColumnType("varchar(255)");
            builder.Property(c => c.Numero).HasColumnName("numero").IsRequired().HasColumnType("varchar(50)");
            builder.Property(c => c.Cep).HasColumnName("cep").IsRequired().HasColumnType("varchar(8)");
            builder.Property(c => c.Complemento).HasColumnName("complemento").HasColumnType("varchar(250)");
            builder.Property(c => c.Bairro).HasColumnName("bairro").IsRequired().HasColumnType("varchar(127)");
            builder.Property(c => c.Cidade).HasColumnName("cidade").IsRequired().HasColumnType("varchar(127)");
            builder.Property(c => c.Estado).HasColumnName("uf").IsRequired().HasColumnType("varchar(50)");
            builder.ToTable("my_endereco");
        }
    }
}