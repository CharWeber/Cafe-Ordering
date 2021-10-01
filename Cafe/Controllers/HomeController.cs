using Microsoft.AspNetCore.Mvc;
using Cafe.Models;

namespace Cafe.Controllers
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