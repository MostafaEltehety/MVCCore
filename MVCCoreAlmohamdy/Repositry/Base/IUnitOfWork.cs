using MVCCoreAlmohamdy.Models;

namespace MVCCoreAlmohamdy.Repositry.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositry<Category> category { get; }
        IRepositry<Item> item { get; }
        IEmpRepo employee { get; }
        int CommitChanges();
    }
}
