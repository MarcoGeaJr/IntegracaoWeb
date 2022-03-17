using Integracao.Business.Interfaces;
using Integracao.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracao.Business.Services
{
    public class SetupService : ISetupService
    {
        public async Task<List<Pedido>> Setup()
        {
            return new List<Pedido>();
        }
    }
}
