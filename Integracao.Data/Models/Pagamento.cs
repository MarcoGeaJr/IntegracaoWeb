using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("Pagamentos")]
    public class Pagamento : Entity
    {
        public Pagamento(int parcela, double valor, FormaPagamento formaPagamento)
        {
            Parcela = parcela;
            Valor = valor;
            FormaPagamento = formaPagamento;
        }

        public int Parcela { get; private set; }
        public double Valor { get; private set; }
        public FormaPagamento FormaPagamento { get; private set; }
    }
}
