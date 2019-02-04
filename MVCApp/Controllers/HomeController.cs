using static DataLibrary.BusinessLogic.EmployeeProcessor;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary.Model;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Enployee Sign Up";

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(MvcEmployee mvcEmployee)
        {
            if (ModelState.IsValid)
            {
                int recordCreated = CreateEmployee(
                    mvcEmployee.EmployeeId,
                    mvcEmployee.FirstName,
                    mvcEmployee.LastName,
                    mvcEmployee.EmailAdress
                    );
                RedirectToAction("Index");
            }

            //Return ti the same page you are
            return View();
        }

        public ActionResult ViewEmployees(MvcEmployee mvcEmployee)
        {
            ViewBag.Message = "Enployee Sign Up";
            var data = LoadEmployees();
            List<MvcEmployee> employees = new List<MvcEmployee>();

            foreach (var row in data)
            {
                employees.Add(new MvcEmployee
                    {
                        EmployeeId = row.EmployeeId,
                        FirstName = row.FirstName,
                        LastName = row.LastName,
                        EmailAdress = row.EmailAdress,
                        ConfirmEmail = row.EmailAdress
                    });
            }

            //Return ti the same page you are
            return View(employees);
        }
    }
}