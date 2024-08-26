using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using crud.Models;
using crud.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace crud.Controllers
{

    public class AutorController : Controller
    {
        private readonly ILogger<AutorController> _logger;
        private readonly IAutor _IAutor;

        public AutorController(ILogger<AutorController> logger, IAutor _IAutor)
        {
            _logger = logger;
            this._IAutor = _IAutor;
        }

        public IActionResult AutorHome()
        {
            return View();
        }
        public IActionResult Update(int id)
        {

            return View(this._IAutor.GetAutorById(id));
        }
        [HttpPost]
        public IActionResult Edited(Autor autor)
        {
            if (ModelState.IsValid)
            {
                this._IAutor.Update(autor);
            }
            return RedirectToAction("display");
        }

        public IActionResult display()
        {
            var Autores = this._IAutor.GetAll();
            return View(Autores);
        }


        [HttpPost]
        public IActionResult Enrolle(Autor autor)
        {
            if (ModelState.IsValid)
            {
                this._IAutor.SaveAutor(autor);
                this._logger.LogInformation("enrrol susseced");
                return RedirectToAction("display");

            }
            return View("AutorHome", autor);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}