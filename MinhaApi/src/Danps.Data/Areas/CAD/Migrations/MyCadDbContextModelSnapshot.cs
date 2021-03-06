// <auto-generated />
using System;
using Danps.Data.Areas.CAD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Danps.Data.Areas.CAD.Migrations
{
    [DbContext(typeof(MyCadDbContext))]
    partial class MyCadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Danps.Business.Areas.CAD.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("seq_my_endereco")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnName("bairro")
                        .HasColumnType("varchar(127)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnName("cep")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnName("cidade")
                        .HasColumnType("varchar(127)");

                    b.Property<string>("Complemento")
                        .HasColumnName("complemento")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("uf")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnName("seq_my_fornecedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnName("logradouro")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnName("numero")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("my_endereco");
                });

            modelBuilder.Entity("Danps.Business.Areas.CAD.Models.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("seq_my_fornecedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnName("ind_ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnName("num_documento")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nom_fornecedor")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TipoFornecedor")
                        .HasColumnName("idt_tipo_fornecedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("my_fornecedor");
                });

            modelBuilder.Entity("Danps.Business.Areas.CAD.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("seq_my_produto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnName("ind_ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("dat_inclusao")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("dsc_produto")
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnName("seq_my_fornecedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnName("dsc_imagem")
                        .HasColumnType("varchar(127)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nom_produto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnName("val_produto")
                        .HasColumnType("varchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("my_produto");
                });

            modelBuilder.Entity("Danps.Business.Areas.CAD.Models.Endereco", b =>
                {
                    b.HasOne("Danps.Business.Areas.CAD.Models.Fornecedor", "Fornecedor")
                        .WithOne("Endereco")
                        .HasForeignKey("Danps.Business.Areas.CAD.Models.Endereco", "FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Danps.Business.Areas.CAD.Models.Produto", b =>
                {
                    b.HasOne("Danps.Business.Areas.CAD.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
