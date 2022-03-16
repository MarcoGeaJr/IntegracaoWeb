using Integracao.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracao.Data.Interfaces
{
    internal interface IRepositoryFind<TEntity> where TEntity : Entity
    {
        Task<TEntity> FindByKey(params object[] keyValue);
    }
}
