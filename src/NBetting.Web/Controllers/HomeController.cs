using Microsoft.AspNetCore.Mvc;

namespace NBetting.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
