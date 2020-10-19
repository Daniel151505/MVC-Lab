using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_lab.Models;

namespace mvc_lab.Controllers{
    public class EstudianteController : Controller{
        private readonly ILogger<EstudianteController> _logger;
        public EstudianteController(ILogger<EstudianteController> logger){
            _logger=logger;
        }
        public IActionResult Index(){

            return View();
        }

        [HttpPost]
        public IActionResult Almacenar(Estudiante estudiante){
            if(ModelState.IsValid)
            {
                estudiante.Answer="Registro de Base de Datos (*)";
            }

            return View("Index",estudiante);
        }
    }
} 