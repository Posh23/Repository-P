

using ConsoleApp1.Entities;

namespace Application.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<Client> GetAsync(Guid id, CancellationToken token = default);
        Task<IEnumerable<Client>> GetAllAsync(CancellationToken token = default);
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default);
        Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken token = default);
    }
}
