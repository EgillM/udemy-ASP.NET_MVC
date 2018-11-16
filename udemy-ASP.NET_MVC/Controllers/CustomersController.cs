using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using udemy_ASP.NET_MVC.Models;

namespace udemy_ASP.NET_MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Ken Flatley"},
                new Customer { Id = 2, Name = "Susan Flatley"}
            };
        }
    }
}