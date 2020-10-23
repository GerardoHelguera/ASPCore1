using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCore1.Models;

namespace ASPCore1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Array array;
            List<EmpleadosModel> Empleados = new List<EmpleadosModel>();
            Empleados.Add(new EmpleadosModel
            {

                Dni_empleado = 13004452,
                Nombre_empleado = "José",
                Ape_paterno = "Morales",
                Ape_materno = "Alvarado",

            });
            Empleados.Add(new EmpleadosModel
            {

                Dni_empleado = 12001245,
                Nombre_empleado = "Carlos",
                Ape_paterno = "Cordova",
                Ape_materno = "Velázquez ",

            });
            Empleados.Add(new EmpleadosModel
            { 

               Dni_empleado = 11003457,
               Nombre_empleado = "María",
               Ape_paterno = "Mireles",
               Ape_materno = "Vargas",
            });

            array = Empleados.ToArray();
            ViewBag.Empleados = array;



            return View();
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
