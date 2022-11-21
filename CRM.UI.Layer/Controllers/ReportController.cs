using CRM.DataAccess.Layer.Concrete;
using CRM.UI.Layer.Models;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;

namespace CRM.UI.Layer.Controllers
{
    public class ReportController : Controller
    {   public IActionResult ReportList()
        {
            return View();  
        }
        // static excel list
        public IActionResult ExcelStatic()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
            worksheet.Cells[1, 1].Value = "Employee ID";
            worksheet.Cells[1, 2].Value = "Employee Name";
            worksheet.Cells[1, 3].Value = "Employee Surname";

            worksheet.Cells[2, 1].Value = "0001";
            worksheet.Cells[2, 2].Value = "Atilla";
            worksheet.Cells[2, 3].Value = "Aksoy";


            worksheet.Cells[3, 1].Value = "0002";
            worksheet.Cells[3, 2].Value = "Arzu";
            worksheet.Cells[3, 3].Value = "Aksoy";


            var bytes = excelPackage.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","employees.xlsx");
        }

        public List<CustomerView> CustomerList()
        {
            List<CustomerView> customerViewModels = new List<CustomerView>();
            using (var context = new Context())
            {
                customerViewModels = context.Customers.Select(x => new CustomerView
                {
                    Email = x.CustomerEmail,
                    Name = x.CustomerName,
                    Surname = x.CustomerSurname,
                    Phone = x.CustomerPhone
                }).ToList();
                return customerViewModels;
            }
        }
        public IActionResult DynamicExcel()
        {
            return View();
        }
    }
}

