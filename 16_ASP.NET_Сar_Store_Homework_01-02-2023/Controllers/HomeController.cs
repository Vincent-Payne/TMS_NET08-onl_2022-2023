using _16_ASP.NET_Practice_01_02_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace _16_ASP.NET_Practice_01_02_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AutoContainer _container;

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
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(uint id, [FromForm] string brand, [FromForm] string model, [FromForm] string year, [FromForm] string price)
        {
            //Deserialize
            if (System.IO.File.Exists("./CarsDB.json"))
            {
                foreach (var jsonLine in System.IO.File.ReadLines("./CarsDB.json"))
                {
                    _container.AddAuto(JsonSerializer.Deserialize<Auto>(jsonLine));
                }
            }
            //Counting ID
            id = _container.GetLastElementId + 1;

            var car = new Auto(id, brand, model, year, price);

            //Serialize to file
            string jsonString = JsonSerializer.Serialize(car);
            System.IO.File.AppendAllText("./CarsDB.json", jsonString + Environment.NewLine);

            return RedirectToAction("Registration");
        }

        //??? При нажатии на Car List на сайте несколько раз, первоначальный вывод дублируется
        // Не знаю что с этим делать
        public IActionResult ListCars()
        {
            //Deserialize
            if (System.IO.File.Exists("./CarsDB.json"))
            {
                foreach (var jsonLine in System.IO.File.ReadLines("./CarsDB.json"))
                {
                    _container.AddAuto(JsonSerializer.Deserialize<Auto>(jsonLine));
                }
            }
            return View(_container.GetAutos());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        //??? Как пирвязывать действия к кнопкам и отображать информацию на той же странице где кнопки?
        public IActionResult Find([FromForm] uint id)
        {
            //Deserialize
            if (System.IO.File.Exists("./CarsDB.json"))
            {
                foreach (var jsonLine in System.IO.File.ReadLines("./CarsDB.json"))
                {
                    Auto auto = JsonSerializer.Deserialize<Auto>(jsonLine);
                    if (auto.Id == id)
                    {
                        return View(auto);
                    }
                }
            }
            //??? Как перенаправить на другой view без лишнего Action?
            return RedirectToAction("FindError");
        }



        public IActionResult FindError()
        {
            ViewData["Message"] = "No such Car! Please, enter another id.";
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}