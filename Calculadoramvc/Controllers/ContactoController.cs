using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_lab.Models;

namespace mvc_lab.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Contacto contacto){
            if(ModelState.IsValid){
                contacto.Respuesta="Gracias estamos en contacto :)";
            }
            return View("Index",contacto);
        }
    }
} 