using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
