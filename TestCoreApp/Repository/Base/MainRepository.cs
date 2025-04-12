using TestCoreApp.Data;

namespace TestCoreApp.Repository.Base
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        public MainRepository(ApplicationDbContext context) 
        {
            this.context = context;
        }
        protected ApplicationDbContext context;

        public T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
