using Formularz.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formularz.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                dane.SuccessMessage = "Rejestracja zakończona pomyślnie";
                return View("Wynik", dane);
            }
            return View();
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
