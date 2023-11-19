using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Produtos produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();    
        }

        public List<Produtos> Get()
        {
            return _context.Produtos.ToList();
        }
    }
}
