using Microsoft.AspNetCore.Mvc;

namespace GitExample.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
