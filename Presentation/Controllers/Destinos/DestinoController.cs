using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.Destinos
{
    public class DestinoController : Controller
    {
        // GET: DestinoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DestinoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DestinoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DestinoController/Create
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

        // GET: DestinoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DestinoController/Edit/5
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

        // GET: DestinoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DestinoController/Delete/5
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
