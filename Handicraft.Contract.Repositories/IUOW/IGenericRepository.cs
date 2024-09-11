

using Handicraft.Core.Base;

namespace Handicraft.Contract.Repositories.IUOW
{
    public interface IGenericRepository<T> where T : class
    {
        // query
        IQueryable<T> Entities { get; }

        // non async
        IEnumerable<T> GetAll();
        T? GetById(object id);
        void Insert(T obj);
        void InsertRange(IList<T> obj);
        void Update(T obj);
        void Delete(object id);
        void Save();

        // async
        Task<IList<T>> GetAllAsync();
        Task<IList<T>> GetWhereAsync(Func<T, bool> predicate);

       Task<BasePaginatedList<T>> GetPagging(IQueryable<T> query, int index, int pageSize);
        Task<T?> GetByIdAsync(object id);
        Task InsertAsync(T obj);
        Task UpdateAsync(T obj);
        Task DeleteAsync(object id);
        Task SaveAsync();
        Task<bool> ExistsAsync(Func<T, bool> predicate);
    }
}
