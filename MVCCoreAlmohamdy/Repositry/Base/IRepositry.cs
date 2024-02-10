using System.Linq.Expressions;

namespace MVCCoreAlmohamdy.Repositry.Base
{
    public interface IRepositry<T> where T : class
    {
        T FindById(int id);
        T SelectOne(Expression<Func<T, bool>> match);
        IEnumerable<T> FindAll();
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindAllAsync(params string[] argers);
        void AddOne(T entity);
        void UpdateOne(T entity);
        void DeleteOne(T entity);
        void AddList(IEnumerable<T> entities);
        void UpdateList(IEnumerable<T> entities);
        void DeleteList(IEnumerable<T> entities);
    }
}
