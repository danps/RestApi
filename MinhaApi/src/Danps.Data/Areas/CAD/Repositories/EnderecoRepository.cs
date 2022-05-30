using Danps.Business.Areas.CAD.Interfaces;
using Danps.Business.Areas.CAD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Danps.Data.Areas.CAD.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MyCadDbContext context) : base(context)
        {
        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}