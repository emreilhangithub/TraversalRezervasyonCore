using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
