using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integracao.Data.Models
{
    [Table("Clientes")]
    public class Cliente : Entity
    {
        public Cliente(
            string? cnpj, 
            string? cpf, 
            string? nome, 
            string? razaoSocial, 
            string email, 
            DateTime dataNascimento)
        {
            Cnpj = cnpj;
            Cpf = cpf;
            Nome = nome;
            RazaoSocial = razaoSocial;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public string? Cnpj { get; set; }
        public string? Cpf { get; set; }
        public string? Nome { get; set; }
        public string? RazaoSocial { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
