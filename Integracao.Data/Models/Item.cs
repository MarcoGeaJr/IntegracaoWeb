using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("ItensPedido")]
    public class Item : Entity
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
