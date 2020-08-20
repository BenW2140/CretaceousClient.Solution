using CretaceousClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CretaceousClient.Controllers
{
  class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

  }
}