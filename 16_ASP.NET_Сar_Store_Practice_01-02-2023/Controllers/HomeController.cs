using _16_ASP.NET_Practice_01_02_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace _16_ASP.NET_Practice_01_02_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AutoContainer _container;
        //List<Auto> auto = new List<Auto>();
        
        public HomeController(ILogger<HomeController> logger, AutoContainer container)
        {
            _logger = logger;
            _container = container;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Reg()
        { return View(); }
        [HttpPost]
        public IActionResult Create([FromForm] string brand, [FromForm] string model, [FromForm] string year, [FromForm] string price)
        {
            var a = new Auto(brand, model, year, price);
            _container.AddAuto(a);
            return RedirectToAction("Index");
        }
        
        public IActionResult Display()
        {
          //ViewBag.Message = _container.GetAutos();
          return View(_container.GetAutos());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}