using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.Abstract
{
    public interface IEmployeeDal : IGenericDal<Employee>
    {
        List<Employee> GetEmpByCategory();
        void ChangeEmployeeStatusToTrue(int id);
        void ChangeEmployeeStatusToFalse(int id);
    }
}
