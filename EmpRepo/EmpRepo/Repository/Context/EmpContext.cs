using EmpRepo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmpRepo
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("conStr") { }
        public DbSet<Employee> Employees { get; set; }
    }
}