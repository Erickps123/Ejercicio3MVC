using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio3ASP.Models;

namespace Ejercicio3ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Datacs Vehiculo)
        {
            if (ModelState.IsValid)
            {
           

                string ID = Vehiculo.ID;
                string nombre = Vehiculo.NOMBRE;
                string color = Vehiculo.COLOR;
                string marca = Vehiculo.MARCA;
                string chasis = Vehiculo.CHASIS;


                string[] DatosCarro = new string[100];


                DatosCarro = new string[5] { ID,nombre,color,marca,chasis };

                   
                for(int i = 0; i <= 99; i++) { 
                
                    ViewData["ID"] = DatosCarro[0];
                    ViewData["NOMBRE"] = DatosCarro[1];
                    ViewData["COLOR"] = DatosCarro[2];
                    ViewData["MARCA"] = DatosCarro[3];
                    ViewData["CHASIS"] = DatosCarro[4];

                }

            }

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
