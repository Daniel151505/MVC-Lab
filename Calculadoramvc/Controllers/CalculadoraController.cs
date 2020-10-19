using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Calculadoramvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Lab.Models;

namespace MVC_Lab.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalculadoraController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Calcular(Calculadora objCalculadora){
    
         if("+".Equals(objCalculadora.Accion)){
            objCalculadora.Respuesta = objCalculadora.Operador1 + objCalculadora.Operador2;
         }
         if("-".Equals(objCalculadora.Accion)){
            objCalculadora.Respuesta = objCalculadora.Operador1 - objCalculadora.Operador2;
         }
         return View("index", objCalculadora);

        }

    }
}
