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
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result=await _appDbContext.Actors.ToListAsync();
            return result;
        }

        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
