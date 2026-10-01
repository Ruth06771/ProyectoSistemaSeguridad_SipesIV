using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblDetalleHorario;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblDetalleHorarioController : ControllerBase
    {
        private readonly ITblDetalleHorarioService _tblDetalleHorarioService;
        public TblDetalleHorarioController(ITblDetalleHorarioService tblDetalleHorarioService)
        {
            _tblDetalleHorarioService = tblDetalleHorarioService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblDetalleHorarioDTO DetalleHorario)
        {
            try
            {
                await _tblDetalleHorarioService.Crear(DetalleHorario);
                return StatusCode(201, new { message = "Detalle de horario creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblDetalleHorarioDTO DetalleHorario)
        {
            try
            {
                await _tblDetalleHorarioService.Actualizar(DetalleHorario);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblDetalleHorarioDTO dto)
        {
            try
            {
                await _tblDetalleHorarioService.Eliminar(dto.lhorario_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idDetalleHorario}")]
        public async Task<ActionResult> ObtenerPorId(int idDetalleHorario)
        {
            try
            {
                var detalleHorario = await _tblDetalleHorarioService.ObtenerPorId(idDetalleHorario);
                if (detalleHorario == null) return NotFound(new { message = $"El detalle de horario con Id {idDetalleHorario} no existe" });
                return Ok(detalleHorario);
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
                return Ok(await _tblDetalleHorarioService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
