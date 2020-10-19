using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_lab.Models;
using mvc_lab.Data;

namespace mvc_lab.Controllers
{
    public class CovidController : Controller
    {
        private readonly ILogger<CovidController> _logger;
        private readonly DatabaseContext _context;

        public CovidController(ILogger<CovidController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Covid covid){
            if(ModelState.IsValid){
                //grabado DB
                covid.Autor="Daniel Chacón";
                _context.Add(covid);
                _context.SaveChanges();            
                covid.Respuesta="Gracias por su registro pronto estaremos en contacto con usted ";
            }
            return View("Index",covid);
        }

        
    }
}