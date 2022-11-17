using CRM.DataAccess.Layer.Abstract;
using CRM.DataAccess.Layer.Concrete;
using CRM.DataAccess.Layer.Repository;
using CRM.Entity.Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.EntityFramework
{
    public class EFEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        public void ChangeEmployeeStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void ChangeEmployeeStatusToTrue(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmpByCategory()
        {
            using (var context = new Context())
            {
                return context.Employees.Include(x=> x.Category).ToList();   
            }
        }
    }
}
