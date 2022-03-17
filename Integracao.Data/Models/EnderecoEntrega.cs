using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("EnderecoEntrega")]
    public class EnderecoEntrega : Entity
    {
        public EnderecoEntrega(
            string endereco, 
            string numero, 
            string cep, 
            string bairro, 
            string cidade, 
            string estado, 
            string? complemento, 
            string? referencia)
        {
            Endereco = endereco;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            Referencia = referencia;
        }

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
