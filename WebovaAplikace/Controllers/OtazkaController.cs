using Microsoft.AspNetCore.Mvc;
using WebovaAplikace.Models;


namespace WebovaAplikace.Controllers
{
    public class OtazkaController : Controller
    {
        public IActionResult Index(Kuryr kuryr)
        {
            kuryr.celkem = (kuryr.penezenka + kuryr.dyska - kuryr.tankovani - kuryr.nakupovani - kuryr.trzba); 
            Kuryr kuryr2 = new Kuryr();
            return View();
        }

        public IActionResult Input()
        {
            var kuryr1 = new Kuryr();
            return View(kuryr1);
        }

        public IActionResult VytvoritKuryra(Kuryr kuryr)
        {
            kuryr.celkem = (kuryr.penezenka + kuryr.dyska - kuryr.tankovani - kuryr.nakupovani - kuryr.trzba);

            return View("Index");

        }
    }
}