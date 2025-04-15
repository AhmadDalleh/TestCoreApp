using TestCoreApp.Repository.Base;
using TestCoreApp.Areas.Employees.Models;
using TestCoreApp.Data;
namespace TestCoreApp.Repository
{
    public class EmployeeRepository : MainRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        private readonly ApplicationDbContext _context;
        public decimal getSalary(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void setPayRoll(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
