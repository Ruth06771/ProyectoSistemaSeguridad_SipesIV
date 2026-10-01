using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblPermisos;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPermisosController : ControllerBase
    {
        private readonly ITblPermisosService _tblPermisosService;
        public TblPermisosController(ITblPermisosService tblPermisosService)
        {
            _tblPermisosService = tblPermisosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblPermisosDTO permisos)
        {
            try
            {
                await _tblPermisosService.Crear(permisos);
                return StatusCode(201, new { message = "Permiso creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPermisosDTO permisos)
        {
            try
            {
                await _tblPermisosService.Actualizar(permisos);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblPermisosDTO dto)
        {
            try
            {
                await _tblPermisosService.Eliminar(dto.lPermisos_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idPermisos}")]
        public async Task<ActionResult> ObtenerPorId(int idPermisos)
        {
            try
            {
                var permisos = await _tblPermisosService.ObtenerPorId(idPermisos);
                if (permisos == null) return NotFound(new { message = $"El permiso con Id {idPermisos} no existe" });
                return Ok(permisos);
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
                return Ok(await _tblPermisosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
