using Integracao.Data.Context;
using Integracao.Data.Interfaces;
using Integracao.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Integracao.Data.Repositories
{
    public class RepositoryFind<TEntity> : IRepositoryFind<TEntity> where TEntity : Entity
    {
        private readonly DbSet<TEntity> _DbSet;
        private readonly IntegracaoDataContext _context;

        public RepositoryFind(IntegracaoDataContext context)
        {
            _DbSet = context.Set<TEntity>();
            _context = context;
        }

        public async Task<IList<TEntity>> FindAll()
            => await _DbSet.ToListAsync();

        public async Task<TEntity> FindById(Guid id)
            => await _DbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<TEntity> FisrtOrDefaultAsNoTracking(Guid id)
            => await _DbSet
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
    }
}
