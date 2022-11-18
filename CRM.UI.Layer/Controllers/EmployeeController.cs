using CRM.Business.Layer.Abstract;
using CRM.Business.Layer.ValidationRules;
using CRM.Entity.Layer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CRM.UI.Layer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var values = employeeService.TGetEmpByCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult result = validationRules.Validate(employee);
            if (result.IsValid)
            {
                employeeService.TInsert(employee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            var values= employeeService.TGetById(id);
            employeeService.TDelete(values);    
            return RedirectToAction("Index");  
        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            var values = employeeService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditEmployee(Employee employee)
        {
            var values = employeeService.TGetById(employee.EmployeeId);
            employee.EmployeeStatus = values.EmployeeStatus;
            employeeService.TUpdate(employee);
            
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            employeeService.TChangeEmployeeStatusToFalse(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            employeeService.TChangeEmployeeStatusToTrue(id);
            return RedirectToAction("Index");
        }


    }
}
