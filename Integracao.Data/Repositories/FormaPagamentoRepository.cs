using Integracao.Data.Context;
using Integracao.Data.Interfaces;
using Integracao.Data.Models;
using System.Linq;

namespace Integracao.Data.Repositories
{
    public class FormaPagamentoRepository : IFormaPagamentoRepository
    {
        private readonly IntegracaoDataContext _context;
        public FormaPagamentoRepository(IntegracaoDataContext context)
        {
            _context = context;
        }
    }
}
