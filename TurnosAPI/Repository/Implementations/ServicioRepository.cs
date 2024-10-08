using TurnosAPI.Models;
using TurnosAPI.Repository.Contratcs;

namespace TurnosAPI.Repository.Implementations
{
    public class ServicioRepository : IServicio
    {
        private readonly turnos2024Context _context;
        public ServicioRepository(turnos2024Context context)
        {
            _context = context;
        }
        public bool Add(TServicio servicio)
        {
            _context.TServicios.Add(servicio);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id, string motivo)
        {
            bool result = _context.TServicios.Any(s => s.Id == id);
            if (result)
            {
                var servicio = _context.TServicios.FirstOrDefault(s => s.Id == id);
                servicio.Borrado = true;
                servicio.Motivo = motivo;
                return _context.SaveChanges() > 0;
            }
            return result;
        }

        public List<TServicio> GetAll(string nombre)
        {
            var result = _context.TServicios.Where(s => s.Borrado == false && s.Nombre == nombre);
            return (List<TServicio>)result;
        }

        public bool Update(TServicio servicio)
        {
            if(!_context.TServicios.Any(s => s.Id == servicio.Id && s.Borrado == false))
            {
                return false;
            }
            var servicioToUpdate = _context.TServicios.FirstOrDefault(s => s.Id == servicio.Id);
            servicioToUpdate.Nombre = servicio.Nombre;
            servicioToUpdate.Costo = servicio.Costo;
            servicioToUpdate.EnPromocion = servicio.EnPromocion;
            return _context.SaveChanges() > 0;
        }
    }
}
