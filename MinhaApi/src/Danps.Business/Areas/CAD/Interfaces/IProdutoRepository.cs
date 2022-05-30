using Danps.Business.Areas.CAD.Models;
using Danps.Business.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Danps.Business.Areas.CAD.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);

        Task<IEnumerable<Produto>> ObterProdutosFornecedores();

        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}