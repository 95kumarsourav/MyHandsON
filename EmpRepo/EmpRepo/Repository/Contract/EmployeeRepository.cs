using EmpRepo.Models;
using EmpRepo.Repository.Contract.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpRepo.Repository.Contract
{
    public class EmployeeRepository : Repository<Employee>, IRepository<Employee>
    {
        public EmployeeRepository(EmpContext context) : base(context)
        {

        }
        EmpContext context = new EmpContext();
    }
}