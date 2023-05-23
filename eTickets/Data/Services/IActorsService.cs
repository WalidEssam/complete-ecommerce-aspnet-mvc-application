using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        Actor Update(int id,Actor actor);
        void Add(Actor actor); 
        void Delete(int id);
    }
}
