using Danps.Business.Areas.CAD.Interfaces;
using Danps.Business.Areas.CAD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Danps.Data.Areas.CAD.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MyCadDbContext context) : base(context)
        {
        }

        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}