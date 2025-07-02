using _7oras.Domain;
using _7oras.Domain.Interfaces;
using _7oras.Infrastructure.EF.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _7oras.Infrastructure.EF.Repos
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : BaseEnt
    {
        #region readonly
        //using readonly so that in multi threads , no thread change the instance of connection (so all classes inheits from BaseRepo will use same _dbContext,_dbset )
        #endregion
        private readonly AppDbContext _dbContext; //represent connection instance
        private readonly DbSet<TEntity> _dbset; //reprsent database table in memory

        public async Task<TEntity> GetAsync(Guid id)
        {
            #region FindAsync(),Tracking().FirstOrDefaultAsync
            // AsNoTracking().FirstOrDefaultAsync => for read-only // better peformance.
            //FindAsync(id) => for write(create-update) as it track entity changes to save it in database when call SaveChnages();
            #endregion  

            var found = await _dbset.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (found == null)
                throw new Exception($"Not old Entity with id : {id}");

            return found;
        }

        public async Task<TEntity> FindAsync(Guid id)
        {
            var found = await _dbset.FindAsync(id);

            if (found == null)
                throw new Exception($"Not old Entity with id : {id}");

            return found;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
                return await _dbset.AsNoTracking().ToListAsync();

            return await _dbset.AsNoTracking().Where(predicate).ToListAsync();
        }


        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var created = await _dbset.AddAsync(entity);
            return created.Entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var old = await FindAsync(entity.Id);

            _dbContext.Entry(old).State = EntityState.Detached; //detach old in dbcontext (database)

            _dbset.Attach(entity); //attach coming in dbset(memory)

            _dbset.Entry(entity).State = EntityState.Modified;//to force update when saveChanges

            return entity;
        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {
            var found = await FindAsync(id);
            _dbset.Remove(found);

            return found;
        }
    }
}
