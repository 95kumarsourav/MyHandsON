using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpRepo.Repository.Contract.Core
{
    public interface IUnitOfWork
    {
        EmployeeRepository Employees { get; }
        int Complete();
    }
}