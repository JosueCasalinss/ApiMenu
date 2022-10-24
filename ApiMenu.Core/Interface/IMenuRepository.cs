using System.Collections.Generic;

namespace ApiMenu.Core.Interface
{
    public interface IMenuRepository
    {

        List<Platillo> MostrarMenu();

        Platillo BuscarMenu(string NombreP);

        string AdicionarMenu(Platillo platillo);

        string ActualizarMenu(Platillo platillo);

        string EliminarMenu(int id);

    }
}
