using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity_Framework_Application
{
    class EmplopyeeContext : DbContext
    {
       public DbSet<Employee> Employees { get; set; } 
    }
}
