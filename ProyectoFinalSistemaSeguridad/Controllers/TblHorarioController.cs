using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblHorario;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblHorarioController : ControllerBase
    {
        private readonly ITblHorarioService _tblHorarioService;
        public TblHorarioController(ITblHorarioService tblHorarioService)
        {
            _tblHorarioService = tblHorarioService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblHorarioDTO horarios)
        {
            try
            {
                await _tblHorarioService.Crear(horarios);
                return StatusCode(201, new { message = "Horario creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblHorarioDTO horarios)
        {
            try
            {
                await _tblHorarioService.Actualizar(horarios);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblHorarioDTO dto)
        {
            try
            {
                await _tblHorarioService.Eliminar(dto.lhorario_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idHorario}")]
        public async Task<ActionResult> ObtenerPorId(int idHorarios)
        {
            try
            {
                var horario = await _tblHorarioService.ObtenerPorId(idHorarios);
                if (horario == null) return NotFound(new { message = $"El horario con Id {idHorarios} no existe" });
                return Ok(horario);
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
                return Ok(await _tblHorarioService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
