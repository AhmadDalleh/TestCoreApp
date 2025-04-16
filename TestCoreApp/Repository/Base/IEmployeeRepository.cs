using TestCoreApp.Areas.Employees.Models;

namespace TestCoreApp.Repository.Base
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
        void setPayRoll(Employee employee);

        decimal getSalary(Employee employee);
    }
}
