using _14_Controllers_25_01_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Text.Json;

namespace _14_Controllers_25_01_2023.Controllers
{
    public class TaskController : Controller
    {
        // Скопировано с https://jayanttripathy.com/ihostingenvironment-and-iwebhostenvironment-in-asp-net-core/
        private readonly ILogger<TaskController> _logger;
        private IWebHostEnvironment _environment;
        public TaskController(ILogger<TaskController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }
        

 
        public IActionResult Task1()
        {
            DataModel model = new DataModel();
            model.dateTime = DateTime.Now;
            model.appEnvironment = _environment.EnvironmentName;
            model.appName = _environment.ApplicationName;
            model.appHost = this.Request.Host.Value;
            model.appProtocol = this.Request.Protocol;
            return View(model);
        }

        public IActionResult Task2()
        {
            ViewBag.JsonString = JsonSerializer.Serialize(new Task2Controller());
            return View();
        }

        public IActionResult Task3(string str1, byte byte1, decimal dec1 )
        {
            ViewData["str1"] = str1;
            ViewData["byte1"] = byte1;
            ViewData["dec1"] = dec1;
            return View();
        }
    }
}
