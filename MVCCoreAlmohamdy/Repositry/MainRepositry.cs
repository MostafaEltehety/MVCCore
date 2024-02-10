using Microsoft.EntityFrameworkCore;
using MVCCoreAlmohamdy.Data;
using MVCCoreAlmohamdy.Repositry.Base;
using System.Linq.Expressions;

namespace MVCCoreAlmohamdy.Repositry
{
    public class MainRepositry<T> : IRepositry<T> where T : class
    {
        private readonly MyAppDbContext _context;

        public MainRepositry(MyAppDbContext context)
        {
            _context = context;
        }

        public void AddList(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
            _context.SaveChanges();
        }

        public void AddOne(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void DeleteList(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            _context.SaveChanges();
        }

        public void DeleteOne(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(params string[] argers)
        {
            IQueryable<T> query = _context.Set<T>();
            if (argers.Length > 0)
            {
                foreach (string item in argers)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public T SelectOne(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        public void UpdateList(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
            _context.SaveChanges();
        }

        public void UpdateOne(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
