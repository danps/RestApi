using Danps.Catalogo.Domain;
using Danps.Core;
using Microsoft.AspNetCore.Mvc;

namespace Danps.Catalogo.Api.Controllers
{
    [Route("api/fornecedor")]
    public class FornecedorController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorController(IFornecedorRepository fornecedorRepository,
                                      INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Fornecedor>> ObterTodos()
        {
            return await _fornecedorRepository.ObterTodos();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Fornecedor>> ObterPorId(Guid id)
        {
            return (await _fornecedorRepository.ObterPorId(id));
        }
    }
}