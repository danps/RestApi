using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Danps.Catalogo.Data.Migrations
{
    public partial class CriarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "my_fornecedor",
                columns: table => new
                {
                    seq_my_fornecedor = table.Column<Guid>(nullable: false),
                    nom_fornecedor = table.Column<string>(type: "varchar(255)", nullable: false),
                    num_documento = table.Column<string>(type: "varchar(20)", nullable: false),
                    idt_tipo_fornecedor = table.Column<int>(nullable: false),
                    ind_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_my_fornecedor", x => x.seq_my_fornecedor);
                });

            migrationBuilder.CreateTable(
                name: "my_endereco",
                columns: table => new
                {
                    seq_my_endereco = table.Column<Guid>(nullable: false),
                    seq_my_fornecedor = table.Column<Guid>(nullable: false),
                    logradouro = table.Column<string>(type: "varchar(255)", nullable: false),
                    numero = table.Column<string>(type: "varchar(50)", nullable: false),
                    complemento = table.Column<string>(type: "varchar(250)", nullable: true),
                    cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    bairro = table.Column<string>(type: "varchar(127)", nullable: false),
                    cidade = table.Column<string>(type: "varchar(127)", nullable: false),
                    uf = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_my_endereco", x => x.seq_my_endereco);
                    table.ForeignKey(
                        name: "FK_my_endereco_my_fornecedor_seq_my_fornecedor",
                        column: x => x.seq_my_fornecedor,
                        principalTable: "my_fornecedor",
                        principalColumn: "seq_my_fornecedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "my_produto",
                columns: table => new
                {
                    seq_my_produto = table.Column<Guid>(nullable: false),
                    seq_my_fornecedor = table.Column<Guid>(nullable: false),
                    nom_produto = table.Column<string>(type: "varchar(255)", nullable: false),
                    dsc_produto = table.Column<string>(type: "varchar(1000)", nullable: false),
                    dsc_imagem = table.Column<string>(type: "varchar(127)", nullable: false),
                    val_produto = table.Column<string>(type: "varchar(1000)", nullable: false),
                    dat_inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ind_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_my_produto", x => x.seq_my_produto);
                    table.ForeignKey(
                        name: "FK_my_produto_my_fornecedor_seq_my_fornecedor",
                        column: x => x.seq_my_fornecedor,
                        principalTable: "my_fornecedor",
                        principalColumn: "seq_my_fornecedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_my_endereco_seq_my_fornecedor",
                table: "my_endereco",
                column: "seq_my_fornecedor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_my_produto_seq_my_fornecedor",
                table: "my_produto",
                column: "seq_my_fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "my_endereco");

            migrationBuilder.DropTable(
                name: "my_produto");

            migrationBuilder.DropTable(
                name: "my_fornecedor");
        }
    }
}
