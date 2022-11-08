using Microsoft.AspNetCore.Mvc;
using WebovaAplikace.Models;


namespace WebovaAplikace.Controllers
{
    public class OtazkaController : Controller
    {
        public IActionResult Index()
        {
            DogviewModel doggo = new DogviewModel() { Name = "Sif", age = 2 };
            return View(doggo);
        }

        public string Otazka()
        {
            return "Zadejte hodnotu penezenky";
        }

    }
}
