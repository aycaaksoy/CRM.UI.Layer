using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entity.Layer.Concrete
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; } 
        public string EmployeeSurname { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeeImage { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
