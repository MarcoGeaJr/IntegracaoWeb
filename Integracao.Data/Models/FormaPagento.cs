using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("FormasPagemento")]
    public class FormaPagamento : Entity
    {
        public FormaPagamento(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public string Codigo { get; private set; }
        public string Nome { get; private set; }
    }
}
