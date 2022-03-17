using Integracao.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Integracao.Data.Interfaces
{
    public interface IRepositoryFind<TEntity> where TEntity : Entity
    {
        Task<IList<TEntity>> FindAll();
        Task<TEntity> FindById(Guid id);
        Task<TEntity> FisrtOrDefaultAsNoTracking(Guid id);
    }
}
