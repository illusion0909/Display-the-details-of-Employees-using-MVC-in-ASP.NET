using DotNet_Project4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace DotNet_Project4.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            //Employee employee=new Employee();
         // Employee employee = new Employee { Empno = 1, Ename = "Amit", Eaddress = "#abc", Esalary = 70000 };

            List<Employee> employees = new List<Employee>
            {
                new Employee{ Empno = 1, Ename = "Amit", Eaddress = "#abc", Esalary = 70000},
                new Employee{ Empno = 2, Ename = "Ankit", Eaddress = "#ahggc", Esalary = 80000},
                new Employee{ Empno = 3, Ename = "Rahul", Eaddress = "#zzz", Esalary = 990000},
                new Employee{ Empno = 4, Ename = "Nitika", Eaddress = "#xyz", Esalary = 90000}

            };
            return View(employees);
        }
        
    }
}