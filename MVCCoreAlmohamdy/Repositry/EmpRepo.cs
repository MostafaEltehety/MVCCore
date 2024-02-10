using MVCCoreAlmohamdy.Data;
using MVCCoreAlmohamdy.Models;
using MVCCoreAlmohamdy.Repositry.Base;

namespace MVCCoreAlmohamdy.Repositry
{
    public class EmpRepo : MainRepositry<Employee>, IEmpRepo
    {
        private readonly MyAppDbContext _context;

        public EmpRepo(MyAppDbContext context) : base(context)
        {
            _context = context;
        }

        public decimal GetSalary(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void PayRoll(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
