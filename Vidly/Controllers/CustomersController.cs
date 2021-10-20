using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith"},
                new Customer { Id = 2, Name = "Mary Williams"}
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith"},
                new Customer { Id = 2, Name = "Mary Williams"}
            };

            int i;

            for (i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                    break;
            }

            return View(customers[i]);
        }
    }
}
