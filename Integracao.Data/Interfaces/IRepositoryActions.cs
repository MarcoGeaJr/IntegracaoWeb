using Integracao.Data.Models;
using System.Threading.Tasks;

namespace Integracao.Data.Interfaces
{
    public interface IRepositoryActions<TEntity> where TEntity : Entity
    {
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<int> SaveChanges();
    }
}
