using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _appDbContext;
        public ActorsService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task Create(Actor actor)
        {
            _appDbContext.Actors.Add(actor);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var obj= _appDbContext.Actors.Where(a => a.Id==id).FirstOrDefault();
            _appDbContext.Actors.Remove(obj);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Actor> GetById(int id)=> await _appDbContext.Actors.FirstOrDefaultAsync(a => a.Id==id);
 

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result=await _appDbContext.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> Update(int id, Actor actor)
        {
            _appDbContext.Actors.Update(actor);
            await _appDbContext.SaveChangesAsync();
            return actor;
        }
    }
}
