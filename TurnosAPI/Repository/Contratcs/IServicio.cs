using TurnosAPI.Models;

namespace TurnosAPI.Repository.Contratcs
{
    public interface IServicio
    {
        List<TServicio> GetAll(string nombre);
        bool Add(TServicio servicio);
        bool Update(TServicio servicio);
        bool Delete(int id, string motivo);
    }
}
