using Danps.Business.Areas.CAD.Models;
using Danps.Business.Core;
using System;
using System.Threading.Tasks;

namespace Danps.Business.Areas.CAD.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}