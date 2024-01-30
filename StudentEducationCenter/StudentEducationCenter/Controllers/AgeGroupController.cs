using Microsoft.AspNetCore.Mvc;
using StudentEducationCenter.Data.Models;
using StudentEducationCenter.Data;
using StudentEducationCenter.ViewModels.Additional;

namespace StudentEducationCenter.Controllers
{
    public class AgeGroupController : Controller
    {

        public ApplicationDbContext context;

        public AgeGroupController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.AgeGroups.ToList());
        }

        public IActionResult Add()
        {
            return View(new AgeGroupViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(AgeGroupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            AgeGroup ageGroup = new AgeGroup()
            {
                AgeGroupName = model.AgeGroupName
            };
            await context.AgeGroups.AddAsync(ageGroup);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            AgeGroup ageGroup = context.AgeGroups.FirstOrDefault(c => c.Id == id);
            if (ageGroup != null)
            {
                context.AgeGroups.Remove(ageGroup);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
