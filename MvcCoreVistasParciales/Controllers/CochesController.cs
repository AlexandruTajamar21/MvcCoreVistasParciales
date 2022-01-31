using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> Cars;

        public CochesController()
        {
            this.Cars = new List<Coche>
            {
                new Coche{IdCoche = 1, Marca = "Pontiac", Modelo = "FireBird",VelocidadMaxima = 320},
                new Coche{IdCoche = 2, Marca = "Lamborghini", Modelo = "Diablo", VelocidadMaxima = 340},
                new Coche{IdCoche = 3, Marca = "Ford", Modelo="Mustang GT", VelocidadMaxima = 300 },
                new Coche{IdCoche = 4, Marca = "Fiat", Modelo="Panda", VelocidadMaxima = 100}
            };
        }

        public IActionResult Index()
        {
            return View(this.Cars);
        }

        public IActionResult PeticionAsincrona()
        {
            return View();
        }

        public IActionResult _CochesPartial()
        {
            return PartialView("_CochesPartial", this.Cars);
        }

        public IActionResult _CochesDetailsPartial(int idcoches)
        {
            Coche car = this.Cars.SingleOrDefault(z => z.IdCoche == idcoches);
            return PartialView("_CochesDetailsPartial", car);
        }
    }
}
