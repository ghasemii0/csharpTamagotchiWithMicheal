using Microsoft.AspNetCore.Mvc;
using Tamagotchi;
using System.Drawing;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class ItemsController : Controller
    {
      [HttpGet("/Index")]
      public ActionResult Index()
      {
        List<Pet> allItems = Pet.GetAll();
          return View(allItems);
      }

      [HttpPost("/Index/new")]
      public ActionResult Fun(int food, int sleep, int play)
      {

          Pet newPet = new Pet(food, sleep, play);
          return RedirectToAction("Index");
      }
    }
}
