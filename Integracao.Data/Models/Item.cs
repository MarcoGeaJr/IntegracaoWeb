using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("ItensPedido")]
    public class Item
    {
        public Guid Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
