using Danps.Business.Areas.CAD.Models;
using System;
using System.Threading.Tasks;

namespace Danps.Business.Areas.CAD.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);

        Task Atualizar(Produto produto);

        Task Remover(Guid id);
    }
}