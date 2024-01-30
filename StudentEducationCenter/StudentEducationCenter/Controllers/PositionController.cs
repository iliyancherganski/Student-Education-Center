using Microsoft.AspNetCore.Mvc;
using StudentEducationCenter.Data;
using StudentEducationCenter.Data.Models;
using StudentEducationCenter.ViewModels.Additional;

namespace StudentEducationCenter.Controllers
{
    public class PositionController : Controller
    {
        public ApplicationDbContext context;

        public PositionController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Positions.ToList());
        }

        public IActionResult Add()
        {
            return View(new PositionViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(PositionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Position position = new Position()
            {
                PositionName = model.PositionName
            };
            await context.Positions.AddAsync(position);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Position position = context.Positions.FirstOrDefault(c => c.Id == id);
            if (position != null)
            {
                context.Positions.Remove(position);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
