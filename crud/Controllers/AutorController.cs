using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace crud.Controllers
{

    public class AutorController : Controller
    {
        private readonly ILogger<AutorController> _logger;

        public AutorController(ILogger<AutorController> logger)
        {
            _logger = logger;
        }

        public IActionResult AutorHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Enrolle(Autor autor)
        {
            if (ModelState.IsValid)
            {
                this._logger.LogInformation("enrrol susseced");
            }
            return View("AutorHome",autor);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}