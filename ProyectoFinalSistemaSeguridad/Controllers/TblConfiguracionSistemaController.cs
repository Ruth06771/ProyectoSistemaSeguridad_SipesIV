using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblConfiguracionSistema;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblConfiguracionSistemaController : ControllerBase
    {
        private readonly ITblConfiguracionSistemaService _tblConfiguracionSistemaService;
        public TblConfiguracionSistemaController(ITblConfiguracionSistemaService tblConfiguracionSistemaService)
        {
            _tblConfiguracionSistemaService = tblConfiguracionSistemaService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblConfiguracionSistemaDTO ConfiguracionSistema)
        {
            try
            {
                await _tblConfiguracionSistemaService.Crear(ConfiguracionSistema);
                return StatusCode(201, new { message = "Configuración creada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblConfiguracionSistemaDTO ConfiguracionSistema)
        {
            try
            {
                await _tblConfiguracionSistemaService.Actualizar(ConfiguracionSistema);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblConfiguracionSistemaDTO dto)
        {
            try
            {
                await _tblConfiguracionSistemaService.Eliminar(dto.lConfig_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idConfiguracionSistema}")]
        public async Task<ActionResult> ObtenerPorId(int idConfiguracionSistema)
        {
            try
            {
                var configuracion = await _tblConfiguracionSistemaService.ObtenerPorId(idConfiguracionSistema);
                if (configuracion == null) return NotFound(new { message = $"La configuración con Id {idConfiguracionSistema} no existe" });
                return Ok(configuracion);
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
                return Ok(await _tblConfiguracionSistemaService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
