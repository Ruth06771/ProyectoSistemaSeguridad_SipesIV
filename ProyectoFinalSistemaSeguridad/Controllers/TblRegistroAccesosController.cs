using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblRegistroAccesos;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblRegistroAccesosController : ControllerBase
    {
        private readonly ITblRegistroAccesosService _tblRegistroAccesosService;
        public TblRegistroAccesosController(ITblRegistroAccesosService tblRegistroAccesosService)
        {
            _tblRegistroAccesosService = tblRegistroAccesosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblRegistroAccesosDTO RegistroAccesos)
        {
            try
            {
                await _tblRegistroAccesosService.Crear(RegistroAccesos);
                return StatusCode(201, new { message = "Registro de acceso creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblRegistroAccesosDTO RegistroAccesos)
        {
            try
            {
                await _tblRegistroAccesosService.Actualizar(RegistroAccesos);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblRegistroAccesosDTO dto)
        {
            try
            {
                await _tblRegistroAccesosService.Eliminar(dto.lRegistro_Accesos_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idRegistro_Accesos}")]
        public async Task<ActionResult> ObtenerPorId(int idRegistroAccesos)
        {
            try
            {
                var registroAcceso = await _tblRegistroAccesosService.ObtenerPorId(idRegistroAccesos);
                if (registroAcceso == null) return NotFound(new { message = $"El registro de acceso con Id {idRegistroAccesos} no existe" });
                return Ok(registroAcceso);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerTodos")]
        public async Task<ActionResult> ObtenerTodos()
        {
            try
            {
                return Ok(await _tblRegistroAccesosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
