using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiMenu.Core.Interface
{
    public interface IOrderRepository
    {
        Task<List<Pedido>> MostrarDomicilios();

        Task<string> AdicionarPedido(Pedido pedido);
    }
}
