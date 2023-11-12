using Microsoft.AspNetCore.Mvc;

namespace LDSMovies.Controllers
{
  public class MovieListController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
