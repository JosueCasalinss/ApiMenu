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
    public class PedidoController : ControllerBase
    {

        private readonly IPedidoRepositorio _pedidoRepositorio;

        public PedidoController(IPedidoRepositorio PedidoRepositorio)
        {

            _pedidoRepositorio = PedidoRepositorio;

        }


        [HttpGet]

        public async Task<IActionResult> GetDomicilios()
        {
            return Ok(await _pedidoRepositorio.MostrarDomicilios());

        }

        [HttpPost]

        public async Task<IActionResult> PostDomicilio(Pedido pedido)
        {

            return Ok(await _pedidoRepositorio.AdicionarPedido(pedido));

        }

    }
}
