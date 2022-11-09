using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NordicForslag.Data;
using NordicForslag.Models;

namespace NordicForslag.Controllers
{
    public class ForslagController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ForslagController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Forslag> objForslagList = _db.Forslags;
            return View(objForslagList);
        }

        public IActionResult Opprett()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Opprett(Forslag obj)
        {
            if (ModelState.IsValid)
            {
                _db.Forslags.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
    
