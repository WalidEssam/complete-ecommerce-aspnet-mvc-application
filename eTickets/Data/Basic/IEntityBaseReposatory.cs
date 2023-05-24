using eTickets.Models;

namespace eTickets.Data.Basic
{
    public interface IEntityBaseReposatory<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Update(int id, T entity);
        Task Create(T entity);
        Task Delete(int id);
    }
}
