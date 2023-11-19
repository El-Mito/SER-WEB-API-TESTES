namespace PrimeiraAPI.Model
{
    public interface IProdutoRepository
    {
        void Add(Produtos produto);

        List<Produtos> Get();
    }
}
