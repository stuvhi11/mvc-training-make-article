using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTask1.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
