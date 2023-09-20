using Microsoft.AspNetCore.Mvc;

namespace Werdle.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}