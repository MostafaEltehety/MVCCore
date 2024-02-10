using MVCCoreAlmohamdy.Models;

namespace MVCCoreAlmohamdy.Repositry.Base
{
    public interface IEmpRepo : IRepositry<Employee>
    {
        decimal GetSalary(Employee employee);
        void PayRoll(Employee employee);
    }
}
