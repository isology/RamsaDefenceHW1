using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RamsaDefenceHW1.Data;
using RamsaDefenceHW1.Models;

namespace RamsaDefenceHW1.Controllers
{
    public class ItemsController : Controller
    {
        private readonly Context _context;

        public ItemsController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _context.Items.ToListAsync();
            return View(item); 
        }

        public IActionResult Create() { 
        
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Name, Price, StockQuantity")] Items item)
        {
            if(ModelState.IsValid)
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");
            }

            return View(item);
        }
    }
}
