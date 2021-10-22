using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return new NotFoundResult();
            }

            return View(customer);
        }
    }
}
