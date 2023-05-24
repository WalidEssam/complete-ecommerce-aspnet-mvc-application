using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Data.Basic
{
    public class EntityReposatory<T> : IEntityBaseReposatory<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _appDbContext;

        public EntityReposatory(AppDbContext context) => _appDbContext = context;
        public async Task Create(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }   

        public async Task Delete(int id)
        {
            var entity= await _appDbContext.Set<T>().FirstOrDefaultAsync(a => a.Id == id);
            EntityEntry entityEntry = _appDbContext.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }




        public async Task<T> GetById(int id) => await _appDbContext.Set<T>().FirstOrDefaultAsync(a => a.Id == id);
        public async Task<IEnumerable<T>> GetAll()=> await _appDbContext.Set<T>().ToListAsync();
   


        public async Task Update(int id, T entity)
        {
            EntityEntry entityEntry=_appDbContext.Entry<T>(entity);
            entityEntry.State= EntityState.Modified;
        }
    }
}
