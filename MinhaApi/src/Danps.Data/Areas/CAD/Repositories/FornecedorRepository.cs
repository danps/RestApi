using Danps.Business.Areas.CAD.Interfaces;
using Danps.Business.Areas.CAD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Danps.Data.Areas.CAD.Repositories
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MyCadDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Produtos)
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}