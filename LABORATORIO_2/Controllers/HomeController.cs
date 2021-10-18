using LABORATORIO_2.Dominio;
using LABORATORIO_2.Models;
using LABORATORIO_2.Models.ViewModel;
using LABORATORIO_2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAlmacen ialmacen;
        public HomeController(ILogger<HomeController> logger, IAlmacen ialmacen)
        {
            _logger = logger;
            this.ialmacen = ialmacen;
        }

        public IActionResult index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AlmacenPersona per)
        {
            if (ModelState.IsValid)
            {
                ialmacen.Save(per);
                return View("Mostrar");
            }
            else
            {
                return View("Index", per);
            }
        }
        //public IActionResult Save(AlmacenPersona persona)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View("Index", persona);
        //    }
        //    else
        //    {
        //        AlmacenPersona p = new()
        //        {
        //            NombrePersona = persona.NombrePersona,
        //            EdadPersona = persona.EdadPersona,
        //            DescripcionPersona = persona.DescripcionPersona
        //        };
        //        ialmacen.Save(p);

        //        var json = ialmacen.Lista();
        //        return View("Mostrar", Json(new { data = json }));
        //    }
        //}
        public IActionResult GetAll()
        {
            var BuscandoTabla = ialmacen.Lista();

            return Json(new { data = BuscandoTabla });

        }
        public IActionResult Mostrar()
        {
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
