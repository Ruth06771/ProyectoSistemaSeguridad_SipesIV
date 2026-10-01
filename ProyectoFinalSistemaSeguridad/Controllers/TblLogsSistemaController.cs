using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblLogsSistema;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblLogsSistemaController : ControllerBase
    {
        private readonly ITblLogsSistemaService _tblLogsSistemaService;
        public TblLogsSistemaController(ITblLogsSistemaService tblLogsSistemaService)
        {
            _tblLogsSistemaService = tblLogsSistemaService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblLogsSistemaDTO logsLogsSistema)
        {
            try
            {
                await _tblLogsSistemaService.Crear(logsLogsSistema);
                return StatusCode(201, new { message = "Log creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblLogsSistemaDTO logsLogsSistema)
        {
            try
            {
                await _tblLogsSistemaService.Actualizar(logsLogsSistema);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblLogsSistemaDTO dto)
        {
            try
            {
                await _tblLogsSistemaService.Eliminar(dto.lLog_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idLogsSistema}")]
        public async Task<ActionResult> ObtenerPorId(int idLogsSistema)
        {
            try
            {
                var logsSistema = await _tblLogsSistemaService.ObtenerPorId(idLogsSistema);
                if (logsSistema == null) return NotFound(new { message = $"El log con Id {idLogsSistema} no existe" });
                return Ok(logsSistema);
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
                return Ok(await _tblLogsSistemaService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
