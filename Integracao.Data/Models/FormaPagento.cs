using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("FormasPagemento")]
    public class FormaPagamento
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}
