using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("Pedidos")]
    public class Pedido : Entity
    {
        public int Numero { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
        public string Status { get; set; }
        public double Desconto { get; set; }
        public double Frete { get; set; }
        public double SubTotal { get; set; }
        public double ValorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public EnderecoEntrega EnderecoEntrega { get; set; }
        public IList<Item> Itens { get; set; }
        public IList<Pagamento> Pagamento { get; set; }
    }
}
