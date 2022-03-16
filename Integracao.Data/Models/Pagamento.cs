using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("Pagamentos")]
    public class Pagamento
    {
        public Guid Id { get; set; }
        public int Parcela { get; set; }
        public double Valor { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}
