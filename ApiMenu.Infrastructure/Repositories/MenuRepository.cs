//using ApiMenu.BaseDatos;
using ApiMenu.Core.Interface;
using ApiMenu.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace ApiMenu.Infrastructure.Repositories
{
    public class MenuRepository: IMenuRepository
    {
        private readonly SurvivorRestaurantDBContext _context;

        public MenuRepository(SurvivorRestaurantDBContext context)
        {
            _context = context;
        }


        public List<Platillo> MostrarMenu()
        {
            return _context.Platillo.ToList();

        }


        public Platillo BuscarMenu(string NombreP)
        {
            return _context.Platillo.ToList().FirstOrDefault(platillo => platillo.NombreP == NombreP);

        }


        public string AdicionarMenu(Platillo platillo)
        {
            _context.Platillo.Add(platillo);
            _context.SaveChanges();

            return "Se a adicionado una nota";
        }

        public string ActualizarMenu(Platillo platillo)
        {
            _context.Platillo.Update(platillo);
            _context.SaveChanges();

            return "Su dato se a actalizado correctamente";
        }


        public string EliminarMenu(int id)
        {
            var platillo = _context.Platillo.ToList().FirstOrDefault(platillo => platillo.Id == id);
            _context.Platillo.Remove(platillo);
            _context.SaveChanges();

            return "Se a eliminado correctamente";

        }




    }
}
