using System.Linq.Expressions;
namespace app.Data
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);

    }
}
