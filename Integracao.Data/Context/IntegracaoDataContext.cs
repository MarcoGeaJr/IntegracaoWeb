using Integracao.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracao.Data.Context
{
    public class IntegracaoDataContext : DbContext
    {
        private readonly string _connectionString;
        public IntegracaoDataContext(string connectionString)
            => _connectionString = connectionString;
#region DbSet
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Item> ItensPedidos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
