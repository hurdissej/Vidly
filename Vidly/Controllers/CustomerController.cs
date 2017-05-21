using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {

        private IEnumerable<Customer> GetCustomers()
        {

            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Johnny Wilkinson"},
                new Customer {Id = 2, Name = "Martin Johnson"}
            };
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Detail(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}