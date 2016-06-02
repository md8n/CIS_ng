using System.Web.Mvc;

namespace CIS_ng.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    [AllowAnonymous]
    public ActionResult Index()
    {
      if (User?.Identity == null)
      {
        
      }

      return View();
    }
  }
}
