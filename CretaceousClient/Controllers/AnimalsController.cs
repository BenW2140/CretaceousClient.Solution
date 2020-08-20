using CretaceousClient.Models;

namespace CretaceousClient.Controllers
{
  class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return ErrorViewModel(allAnimals);
    }
    
  }
}