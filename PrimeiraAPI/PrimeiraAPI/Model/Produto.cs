using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Model
{
    public class Produtos
    {
        [Key]

        public int id { get; private set; }

        public string nome { get; private set; }

        public decimal valor { get; private set; }

        public Produtos(string nome, decimal valor ) 
        {
            try
            {
                this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
                this.valor = valor;
            }
            catch (Exception)
            {

                throw;
            }

            
        }    
    }
}
