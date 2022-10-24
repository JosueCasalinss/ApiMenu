using ApiMenu.Core.Entidad;
using ApiMenu.Core.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepositorio _menuRepositorio;

        public MenuController(IMenuRepositorio MenuRepositorio)
        {

            _menuRepositorio = MenuRepositorio;
        
        }

        [HttpGet]

        public IActionResult GetMenu()
        {
            return Ok( _menuRepositorio.MostrarMenu());

        }

        [HttpGet("{NombreP}")]

        public IActionResult GetBuscar(string NombreP)
        {
            return Ok(_menuRepositorio.BuscarMenu(NombreP));
        }

        [HttpPost]
        public IActionResult PostMenu(Platillo platillo)
        {

            return Ok(_menuRepositorio.AdicionarMenu(platillo));

        }

        [HttpPut]

        public IActionResult PutMenu(Platillo platillo)
        {

            return Ok(_menuRepositorio.ActualizarMenu(platillo));
        }

        [HttpDelete]

        public IActionResult DeleteMenu(int id)
        {
            return Ok(_menuRepositorio.EliminarMenu(id));
        }







    }
}
