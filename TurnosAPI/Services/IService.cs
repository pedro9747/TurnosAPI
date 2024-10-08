using TurnosAPI.Models;

namespace TurnosAPI.Services
{
    public interface IService
    {
        List<TServicio> GetServicios(string nombre);
        bool AddServicio(TServicio servicio);
        bool UpdateServicio(TServicio servicio);
        bool DeleteServicio(int id, string motivo);
    }
}
