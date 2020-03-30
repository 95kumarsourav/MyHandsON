using EmpRepo.Repository.Contract.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpRepo.Repository.Contract
{
    public class UnitOfWork : IUnitOfWork
    {
        private EmployeeRepository erepository;
        private EmpContext cc;
        public UnitOfWork(EmpContext cc)
        {
            this.cc = cc;
            erepository = new EmployeeRepository(cc);
        }
        public EmployeeRepository Employees
        {
            get
            {
                return erepository;
            }
        }
        public int Complete()
        {
            return cc.SaveChanges();
        }
        public void Dispose()
        {
            cc.Dispose();
        }
    }
}