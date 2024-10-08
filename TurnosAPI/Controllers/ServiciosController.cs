using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurnosAPI.Models;
using TurnosAPI.Services;

namespace TurnosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        IService _service;
        public ServiciosController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetServicios(string nombre)
        {
            List<TServicio> lista = _service.GetServicios(nombre);
            if(lista.Count == 0)
            {
                return NotFound("No se encontraron servicios con ese nombre");
            }
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult AddServicio(TServicio servicio)
        {
            if (_service.AddServicio(servicio))
            {
                return Ok("Servicio agregado correctamente");
            }
            return BadRequest("No se pudo agregar el servicio");
        }
        [HttpPut]
        public IActionResult UpdateServicio(TServicio servicio)
        {
            if (_service.UpdateServicio(servicio))
            {
                return Ok("Servicio actualizado correctamente");
            }
            return BadRequest("No se pudo actualizar el servicio");
        }
        [HttpDelete]
        public IActionResult DeleteServicio(int id, string motivo)
        {
            if (_service.DeleteServicio(id, motivo))
            {
                return Ok("Servicio eliminado correctamente");
            }
            return BadRequest("No se pudo eliminar el servicio");
        }
    }
}
