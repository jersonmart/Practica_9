using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practica_9.Models;

namespace Practica_9.Controllers
{
    public class equiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public equiposController(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }

        public IActionResult Index()
        {
            var listadeMarcas = (from m in _equiposDbContext.marcas select m).ToList();
            ViewData["listadodeMarcas"] = new SelectList(listadeMarcas, "id_marcas", "nombre_marca");

            var listadodeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        marca_id = e.marca_id,
                                        marca_nombre = m.nombre_marca
                                    }).ToList();

            ViewData["listadoEquipo"] = listadodeEquipos;

            return View();
        }

        public IActionResult CrearEquipos(equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }


}
