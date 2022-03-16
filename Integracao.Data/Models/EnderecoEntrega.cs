using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("EnderecoEntrega")]
    public class EnderecoEntrega : Entity
    {
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        #nullable enable
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
    }
}
