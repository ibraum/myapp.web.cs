using Microsoft.AspNetCore.Mvc;
using MyApp.web.Models;

namespace MyApp.web.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "Bag"}; //Le ID est généré automatiquement
            return View(item);
        }

        public IActionResult Test ()
        {
            return View();
        }

        public IActionResult Create (Item item)
        {
            return View(item);
        }
    }
}
