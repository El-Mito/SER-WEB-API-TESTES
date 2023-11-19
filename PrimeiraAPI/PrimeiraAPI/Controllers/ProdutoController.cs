using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Model;
using PrimeiraAPI.ViewModel;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]

    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ?? throw new ArgumentNullException(nameof(produtoRepository));
        }

        [HttpPost]
        public IActionResult Add(ProdutoViewModel produtoViewModel)
        {
            var produto = new Produtos(produtoViewModel.nome, produtoViewModel.valor);

            _produtoRepository.Add(produto);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produto = _produtoRepository.Get();

            return Ok(produto); 
        }
    }
}
