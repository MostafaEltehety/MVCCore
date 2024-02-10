using MVCCoreAlmohamdy.Data;
using MVCCoreAlmohamdy.Models;
using MVCCoreAlmohamdy.Repositry.Base;

namespace MVCCoreAlmohamdy.Repositry
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyAppDbContext _context;

        public UnitOfWork(MyAppDbContext context)
        {
            _context = context;
            category = new MainRepositry<Category>(_context);
            item = new MainRepositry<Item>(_context);
            employee = new EmpRepo(_context);
        }

        public IRepositry<Category> category { get; private set; }

        public IRepositry<Item> item { get; private set; }

        public IEmpRepo employee { get; private set; }

        public int CommitChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
