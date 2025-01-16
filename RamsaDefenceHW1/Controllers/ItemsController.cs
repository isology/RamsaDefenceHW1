using Microsoft.AspNetCore.Mvc;
using RamsaDefenceHW1.Models;

namespace RamsaDefenceHW1.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Items() { Name = "Laptop" };
            return View(item);
        }

        public IActionResult Edit(int id)
        {

            return Content("id= " + id);

        }
    }
}
