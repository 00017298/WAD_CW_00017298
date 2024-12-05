namespace _00017298_API.Repositories
{
    public interface IRepository_00017298<T>
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
