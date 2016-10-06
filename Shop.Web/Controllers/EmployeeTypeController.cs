using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.IServices;

namespace Shop.Web.Controllers
{
    public class EmployeeTypeController : Controller
    {
        private readonly IEmployeeTypeService _employeeTypeService;

        public EmployeeTypeController()
        {
            
        }
        public EmployeeTypeController(IEmployeeTypeService employeeTypeService)
        {
            _employeeTypeService = employeeTypeService;
        }

        // GET: EmployeeType
        public ActionResult EmployeeTypeList()
        {
            var employeeTypes = _employeeTypeService.ListEmployeeTypes();

            return View(employeeTypes);
        }
    }
}