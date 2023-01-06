using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MSS.Data;
using MSS.Models;
using MSS.Models.Domain;

namespace MSS.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel addProduct)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = addProduct.Name,
                MadeBy = addProduct.MadeBy,
                Type = addProduct.Type,
                Description = addProduct.Description
            };

            await _appDbContext.Product.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var ProductList = await _appDbContext.Product.ToListAsync();
            return View(ProductList);
        }
    }
}