using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework_Application
{
    class Employee
    {
        [Key]
        public int Eid {set; get;}
        public string Ename { set; get; }
        public string Designation { set; get; }
        public double Salary { set; get; }
    }
}
