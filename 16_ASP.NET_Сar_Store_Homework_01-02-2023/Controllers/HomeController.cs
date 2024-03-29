﻿using _16_ASP.NET_Practice_01_02_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Net.Http.Json;
using System.Reflection;
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


        public IActionResult ListCars()
        {
            _container.Clear();
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
            return RedirectToAction("AnError");
        }

        [HttpPost]
        public IActionResult Delete([FromForm] uint id)
        {
            _container.Clear();
            string flag = "False";
            //Deserialize
            if (System.IO.File.Exists("./CarsDB.json"))
            {
                foreach (var jsonLine in System.IO.File.ReadLines("./CarsDB.json"))
                {
                    Auto auto = JsonSerializer.Deserialize<Auto>(jsonLine);
                    _container.AddAuto(auto);
                    if (auto.Id == id) { flag = "True"; }
                }
            }

            if (flag == "True")
            {
                _container.DeleteCar(id);
                System.IO.File.Delete("./CarsDB.json");
                //Serialize to file;
                foreach (var Auto in _container.GetAutos())
                { 
                string jsonString = JsonSerializer.Serialize(Auto);
                System.IO.File.AppendAllText("./CarsDB.json", jsonString + Environment.NewLine);
                }
                return RedirectToAction("ListCars");
            }
            return RedirectToAction("AnError");
        }



        public IActionResult AnError()
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