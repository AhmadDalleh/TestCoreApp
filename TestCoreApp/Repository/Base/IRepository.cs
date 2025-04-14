namespace TestCoreApp.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        public T FindById(int id);
        public IEnumerable<T> FindAll();

    }
}
