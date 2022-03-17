using Integracao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Integracao.Data.Context
{
    public class IntegracaoDataContext : DbContext
    {
        public IntegracaoDataContext(DbContextOptions<IntegracaoDataContext> options)
            : base(options) { }

        #region DbSet
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Item> ItensPedidos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
