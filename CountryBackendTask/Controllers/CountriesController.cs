using CountryBackendTask.Models.Contexts;
using CountryBackendTask.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryBackendTask.Controllers
{
    public class CountriesController : Controller
    {
        private readonly DataContext db;

        public CountriesController(DataContext db) {
            this.db = db;
        }
        public IActionResult Index()
        {
            var countries=db.Countries.ToList();
            return View(countries);
        }
        public IActionResult Details(int id)
        {
            var country = db.Countries.Where(m=>m.Id==id).FirstOrDefault();
            return View(country);
        }
        public IActionResult Edit(int id)
        {
            var country = db.Countries.Where(m => m.Id == id).FirstOrDefault();
            return View(country);
        }
        [HttpPost]
        public IActionResult Edit(Country model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country model)
        {
            db.Countries.Add(model);
            db.SaveChanges();
            return Redirect("Index");
        }

        public IActionResult Remove(int id)
        {
            var country = db.Countries.Where(m => m.Id == id).FirstOrDefault();
            db.Countries.Remove(country);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
