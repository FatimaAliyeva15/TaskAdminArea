
using AdminArea_Pronia.DAL;
using AdminArea_Pronia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminArea_Pronia.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _dbContext.Products.Include(x => x.ProductPhotos).Where(x => x.ProductPhotos.Count>0).ToListAsync();
            return View(products);
        }

    }
}
