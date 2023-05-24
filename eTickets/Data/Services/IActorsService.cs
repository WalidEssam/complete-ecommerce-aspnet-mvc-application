using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> GetById(int id);
        Task<Actor> Update(int id,Actor actor);
        Task Create(Actor actor); 
        Task Delete(int id);
    }
}
