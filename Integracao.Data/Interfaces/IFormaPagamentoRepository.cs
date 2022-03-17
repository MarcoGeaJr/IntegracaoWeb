using Integracao.Data.Models;

namespace Integracao.Data.Interfaces
{
    public interface IFormaPagamentoRepository : IRepositoryFind<FormaPagamento>
    {
        bool ValidarCodigoExistente(string codigo);
    }
}
