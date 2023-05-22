using Microsoft.AspNetCore.Mvc;
using WebApplicationTask1.Models;

namespace WebApplicationTask1.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ILogger<ArticleController> _logger;
        //create dbContext variable
        private readonly MyDbContext _context;
       


        public ArticleController(ILogger<ArticleController> logger, MyDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        public IActionResult Index()
        {
            var articles = _context.Articles.ToList();
            return View(articles);
        }

        public IActionResult Create()
        {
        return View();
        }
    }
}
