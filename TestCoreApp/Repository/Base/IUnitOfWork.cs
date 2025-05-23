﻿using TestCoreApp.Areas.Employees.Models;
using TestCoreApp.Models;

namespace TestCoreApp.Repository.Base
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Category> categories {  get; }
        IRepository<Item> items { get; }
        IEmployeeRepository employees { get; }

        int CommitChanges();
    }
}
