using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Integracao.Data.Models
{
    [Table("Pedidos")]
    public class Pedido : Entity
    {
        private IList<Item> _itens;
        private IList<Pagamento> _pagamentos;

        public Pedido(
            int numero,
            string status, 
            double? desconto, 
            double? frete, 
            double subTotal, 
            double valorTotal, 
            Cliente cliente, 
            EnderecoEntrega enderecoEntrega)
        {
            Numero = numero;
            DataCriacao = DateTime.UtcNow;
            DataAlteracao = DateTime.UtcNow;
            Status = status;
            Desconto = desconto;
            Frete = frete;
            SubTotal = subTotal;
            ValorTotal = valorTotal;
            Cliente = cliente;
            EnderecoEntrega = enderecoEntrega;
            _itens = new List<Item>();
            _pagamentos = new List<Pagamento>();
        }

        public int Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public string Status { get; private set; }
        public double? Desconto { get; private set; }
        public double? Frete { get; private set; }
        public double SubTotal { get; private set; }
        public double ValorTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public EnderecoEntrega EnderecoEntrega { get; private set; }
        public IReadOnlyCollection<Item> Itens { get { return _itens.ToArray(); } }
        public IReadOnlyCollection<Pagamento> Pagamento { get { return _pagamentos.ToArray(); } }

        public void AddItem(Item item)
            => _itens.Add(item);
        public void AddPagamento(Pagamento pagamento)
            => _pagamentos.Add(pagamento);
        public void UpdateStatus(string status)
        {
            Status = status;
            DataAlteracao = DateTime.UtcNow;
        }
    }
}