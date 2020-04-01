using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Models;

namespace MiPrimeraApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase {
        List<Articulo> articulos { set; get; }

        public ArticuloController () {
            articulos = new List<Articulo> () {
                new Articulo { Id = 1, Nombre = "Laptop", Descripcion = "Laptop HP", Precio = 1500, FechaRegistro = new DateTime (2020, 03, 14) },
                new Articulo { Id = 2, Nombre = "Impresora", Descripcion = "Impresora EPSON", Precio = 8700, FechaRegistro = new DateTime (2020, 03, 15) },
                new Articulo { Id = 3, Nombre = "Monitor", Descripcion = "Monitor ASUS", Precio = 1600, FechaRegistro = new DateTime (2020, 03, 16) },
                new Articulo { Id = 4, Nombre = "Cable USB", Descripcion = "Cable USB Genérico", Precio = 193, FechaRegistro = new DateTime (2020, 03, 17) }
            };
        }

        // GET api/articulo
        [HttpGet]
        [Route ("")]
        public IActionResult Obtener () {
            return Ok (articulos);
        }
    }
}