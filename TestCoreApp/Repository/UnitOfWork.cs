using TestCoreApp.Areas.Employees.Models;
using TestCoreApp.Data;
using TestCoreApp.Models;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext context) 
        {
            _context = context;
            categories = new MainRepository<Category>(_context);
            items = new MainRepository<Item>(_context);
            employees = new EmployeeRepository(_context);

        }
        private readonly ApplicationDbContext _context;

        public IRepository<Category> categories { get; private set; }

        public IRepository<Item> items { get; private set; }

        public IEmployeeRepository employees { get; private set; }

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
