using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblPisos;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPisosController : ControllerBase
    {
        private readonly ITblPisosService _tblPisosService;
        public TblPisosController(ITblPisosService tblPisosService)
        {
            _tblPisosService = tblPisosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblPisosDTO pisos)
        {
            try
            {
                await _tblPisosService.Crear(pisos);
                return StatusCode(201, new { message = "Piso creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPisosDTO pisos)
        {
            try
            {
                await _tblPisosService.Actualizar(pisos);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblPisosDTO dto)
        {
            try
            {
                await _tblPisosService.Eliminar(dto.lPisos_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idPisos}")]
        public async Task<ActionResult> ObtenerPorId(int idPisos)
        {
            try
            {
                var pisos = await _tblPisosService.ObtenerPorId(idPisos);
                if (pisos == null) return NotFound(new { message = $"El piso con Id {idPisos} no existe" });
                return Ok(pisos);
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
                return Ok(await _tblPisosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
