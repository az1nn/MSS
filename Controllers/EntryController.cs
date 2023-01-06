using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MSS.Data;
using MSS.Models;
using MSS.Models.Domain;

namespace MSS.Controllers
{
  [Route("[controller]")]
    public class EntryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public EntryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Add()
        {
            var ProductList = await _appDbContext.Product.ToListAsync();
            ViewBag.ProductsList = new SelectList(ProductList, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEntryViewModel request)
        {
            var entry = new Entry()
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                Date = request.Date,
                Local = request.Local,
            };

            // await _appDbContext.Entry.AddAsync(entry);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}