using Microsoft.AspNetCore.Mvc;
using WebApplication6.DAL;

namespace WebApplication6.Controllers
{
    public class CarController : Controller
    {
        readonly CarDbContext _carDbContext;

        public CarController(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }

        public IActionResult Index(int? modelId)
        {
            if (modelId is null) return View(_carDbContext.Cars.ToList());
            if (_carDbContext.Cars.Any(m => m.ModelId == modelId)) return View(_carDbContext.Cars.Where(m => m.ModelId == modelId).ToList());
            return BadRequest();
        }
        public IActionResult Detail(int? id)
        {
            if (id is null) return BadRequest();
            var existCar = _carDbContext.Cars.Find(id);
            if (existCar is null) return NotFound();
            return View(existCar);
        }
    }
}
