using Integracao.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Integracao.Business.Interfaces
{
    public interface ISetupService
    {
        Task<List<Pedido>> Setup();
    }
}
