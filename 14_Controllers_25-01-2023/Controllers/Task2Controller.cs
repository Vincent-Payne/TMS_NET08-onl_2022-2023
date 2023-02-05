using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_Controllers_25_01_2023.Controllers
{
    //Создан автоматом из MVC with read/write actions
    //Даже не вникал, что написано :)
    public class Task2Controller : Controller
    {
        // GET: Task2Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Task2Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task2Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task2Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Task2Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task2Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Task2Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task2Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
