using Integracao.Data.Models;

namespace Integracao.Data.Interfaces
{
    public interface IFormaPagamentoRepository : IRepository<FormaPagamento>
    {
        bool ValidarCodigoExistente(string codigo);
    }
}
