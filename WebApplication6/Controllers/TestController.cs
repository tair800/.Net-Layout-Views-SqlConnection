using Microsoft.AspNetCore.Mvc;
using WebApplication6.ViewModels;

namespace WebApplication6.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            TestVM testVM = new();
            testVM.Marka = new() { Id = 1, Name = "Marka1" };
            testVM.Cars = new()
            {
             new(){Id=1, Name="Car1"},
             new(){Id=2, Name="Car2"},
             new(){Id=3, Name="Car3"}
            };

            return View(testVM);
        }
    }
}
