using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("ItensPedido")]
    public class Item : Entity
    {
        public Item(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
    }
}
