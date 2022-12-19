using Microsoft.AspNetCore.Mvc;

namespace OneToManyRelCore.Controllers
{
    public class OneToManyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
