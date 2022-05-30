using Danps.Business.Areas.CAD.Models;
using Danps.Business.Core;
using System;
using System.Threading.Tasks;

namespace Danps.Business.Areas.CAD.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}