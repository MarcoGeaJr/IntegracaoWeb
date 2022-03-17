using Integracao.Data.Context;
using Integracao.Data.Interfaces;
using Integracao.Data.Models;
using System.Linq;

namespace Integracao.Data.Repositories
{
    public class FormaPagamentoRepository : RepositoryFind<FormaPagamento>, IFormaPagamentoRepository
    {
        public FormaPagamentoRepository(IntegracaoDataContext context)
            : base(context) { }
        public bool ValidarCodigoExistente(string codigo)
            => _DbSet.Any(x => x.Codigo == codigo);
    }
}
