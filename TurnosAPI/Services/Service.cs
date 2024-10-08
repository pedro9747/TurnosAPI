using TurnosAPI.Models;
using TurnosAPI.Repository.Contratcs;

namespace TurnosAPI.Services
{
    public class Service : IService
    {
        private readonly IServicio _servicio;
        public Service(IServicio servicio)
        {
            _servicio = servicio;
        }

        public bool AddServicio(TServicio servicio)
        {
            return _servicio.Add(servicio);
        }

        public bool DeleteServicio(int id, string motivo)
        {
            return _servicio.Delete(id, motivo);
        }

        public List<TServicio> GetServicios(string nombre)
        {
            return _servicio.GetAll(nombre);
        }

        public bool UpdateServicio(TServicio servicio)
        {
            return _servicio.Update(servicio);
        }
    }
}
