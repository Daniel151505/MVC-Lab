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
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
          private readonly DatabaseContext _context;
       public ContactoController(ILogger<ContactoController> logger,
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
        public IActionResult Registrar(Contacto contacto){
            if(ModelState.IsValid){
                 //grabado DB
                _context.Add(contacto);
                _context.SaveChanges();
                contacto.Respuesta="Gracias estamos en contacto :)";
            }
            return View("Index",contacto);
        }
    }
} 