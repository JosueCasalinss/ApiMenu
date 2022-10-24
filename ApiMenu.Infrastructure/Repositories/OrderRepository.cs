using ApiMenu.Core.Interface;
using ApiMenu.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiMenu.Infrastructure.Repositorios
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SurvivorRestaurantDBContext _context;
        public OrderRepository(SurvivorRestaurantDBContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> MostrarDomicilios()
        {
            return await _context.Pedido.ToListAsync();

        }


        public async Task<string> AdicionarPedido(Pedido pedido)
        {
            string[] comidas = pedido.OrdenDomicilio.Split(",");

            double total = 0;
            double totalOrdenes = 0;

            foreach (string platillo in comidas)
            {

                var obj = await _context.Platillo.FirstOrDefaultAsync(x => x.NombreP == platillo);

                if (obj == null)
                {
                    return "Su pedido no puede argarse debido a que no contamos con: " + platillo + " en el menu";
                }

                else
                {
                    totalOrdenes += obj.ValorP;
                }
            }



            if (pedido.Distancia <= 1) total += 5000;

            else if (pedido.Distancia > 1 && pedido.Distancia < 10) total += 10000;

            else total += 15000;

            if (totalOrdenes > 200000) total = total - totalOrdenes * 0.3;


            total += totalOrdenes;
            pedido.TotalPagar = total;
            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();

            return "Se realizo ingreso de domicilio con un valor de: " + pedido.TotalPagar;

        }

    }
}
