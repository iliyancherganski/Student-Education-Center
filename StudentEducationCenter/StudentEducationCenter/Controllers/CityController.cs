using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEducationCenter.Data;
using StudentEducationCenter.Data.Models;
using StudentEducationCenter.ViewModels.Additional;

namespace StudentEducationCenter.Controllers
{
    public class CityController : Controller
    {
        public ApplicationDbContext context;

        public CityController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Cities.ToList());
        }

        public IActionResult Add()
        {
            return View(new CityViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            City city = new City()
            {
                CityName = model.CityName
            };
            await context.Cities.AddAsync(city);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            City city = context.Cities.FirstOrDefault(c => c.Id == id);
            if (city != null)
            {
                context.Cities.Remove(city);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
