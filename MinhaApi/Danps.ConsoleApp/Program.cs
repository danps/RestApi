using Danps.Business.Areas.CAD.Models;
using Danps.Data.Areas.CAD;
using System;

namespace Danps.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            using (var context = new MyCadDbContext())
            { 

                var f2 = new Fornecedor()
                {
                    Nome = "Herói sem poderes",
                    Documento = "01234567890",
                    TipoFornecedor = Business.Areas.CAD.Enums.TipoFornecedor.PessoaFisica,
                    Endereco = new Endereco
                    {
                        Bairro = "Edifício Anexo II - A",
                        Cidade = "Brasília",
                        Cep = "70175900",
                        Estado = "MG",
                        Numero = "100",
                        Logradouro = "Praça dos Três Poderes?",
                    },
                    Ativo = true, 
                    Produtos = new Produto[]
                    {
                        new Produto {
                            Nome = "Lei Orçamentaria",
                            Descricao = "Proposta de melhoria ou de simplificação dos serviços oferecidos",
                            Valor = new decimal(2705.22),
                            DataCadastro = DateTime.Now,
                            Imagem = "",
                            Ativo = true
                        },
                        new Produto {
                            Nome = "Acesso à informação",
                            Descricao = "Obtenha auxílio no peticionamento",
                            Valor = new decimal(230.22),
                            DataCadastro = DateTime.Now,
                            Imagem = "",
                            Ativo = true
                        }, 
                    }
                };


                var f1 = new Fornecedor()
                {
                    Nome = "Cabadra, Inc. (1914–1915)",
                    Documento = "12345678910",
                    TipoFornecedor = Business.Areas.CAD.Enums.TipoFornecedor.PessoaFisica,
                    Endereco = new Endereco
                    {
                        Bairro = "Zona Cívico-Administrativa",
                        Cidade = "Brasília",
                        Cep = "70165900",
                        Estado = "MG",
                        Numero = "100",
                        Logradouro = "Praça dos Três Poderes",
                    },
                    Ativo = true,
                    Produtos = new Produto[]
                    {
                        new Produto {
                            Nome = "Plenário da Câmara",
                            Descricao = "Plenário da Câmara dos Deputados",
                            Valor = new decimal(2705.22),
                            DataCadastro = DateTime.Now,
                            Imagem = "",
                            Ativo = true
                        },
                        new Produto {
                            Nome = "Sessão Convocada",
                            Descricao = "Resultado da ultima sessão deliberativa",
                            Valor = new decimal(230.22),
                            DataCadastro = DateTime.Now,
                            Imagem = "",
                            Ativo = true
                        },
                        new Produto {
                            Nome = "Plenário do Senado",
                            Descricao = "Plenário do Senado Federal",
                            Valor = new decimal(1205.22),
                            DataCadastro = DateTime.Now,
                            Imagem = "",
                            Ativo = true
                        }
                    }
                };

                context.Fornecedores.Add(f1);
                context.Fornecedores.Add(f2);
                context.SaveChanges();
            }
        }
    }
}
