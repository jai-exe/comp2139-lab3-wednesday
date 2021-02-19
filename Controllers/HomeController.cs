using comp2139_lab3_wednesday.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace comp2139_lab3_wednesday.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            var contacts = context.Contacts
                           .Include(c => c.Category)
                           .OrderBy(c => c.Firstname).ToList();

            return View(contacts);
        }
    }
}
