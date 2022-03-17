using Integracao.Data.Models;

namespace Integracao.Data.Interfaces
{
    public interface IFormaPagamento : IRepositoryFind<FormaPagamento>
    {
        bool ValidarCodigoExistente(string codigo);
    }
}
