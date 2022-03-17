using Integracao.Data.Context;
using Integracao.Data.Interfaces;
using Integracao.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Integracao.Data.Repositories
{
    public class RepositoryActions<TEntity> : IRepositoryActions<TEntity> where TEntity : Entity
    {
        private readonly DbSet<TEntity> _DbSet;
        private readonly IntegracaoDataContext _context;

        public RepositoryActions(IntegracaoDataContext context)
        {
            _DbSet = context.Set<TEntity>();
            _context = context;
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await _context.AddAsync(entity);
            await SaveChanges();

            return entity;
        }
        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Update(entity);
            await SaveChanges();

            return entity;
        }
        public async Task<bool> Delete(TEntity entity)
        {
            _context.Remove(entity);
            await SaveChanges();

            return true;
        }
        public async Task<int> SaveChanges()
            => await _context.SaveChangesAsync();
    }
}
