using Microsoft.AspNetCore.Mvc;
using StudentEducationCenter.Data.Models;
using StudentEducationCenter.Data;
using StudentEducationCenter.ViewModels.Additional;

namespace StudentEducationCenter.Controllers
{
    public class SpecialtyController : Controller
    {
        public ApplicationDbContext context;

        public SpecialtyController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Specialties.ToList());
        }

        public IActionResult Add()
        {
            return View(new SpecialtyViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SpecialtyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Specialty position = new Specialty()
            {
                SpecialtyName = model.SpecialtyName
            };
            await context.Specialties.AddAsync(position);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Specialty specialty = context.Specialties.FirstOrDefault(c => c.Id == id);
            if (specialty != null)
            {
                context.Specialties.Remove(specialty);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
