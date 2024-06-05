using Microsoft.AspNetCore.Mvc;
using WebApplication6.DAL;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        List<Marka> Markas;
        CarDbContext _carDbContext;

        public HomeController(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }



        public IActionResult Index()
        {
            return View(_carDbContext.Markas.ToList());
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
