using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblPerfiles;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPerfilesController : ControllerBase
    {
        private readonly ITblPerfilesService _tblPerfilesService;
        public TblPerfilesController(ITblPerfilesService tblPerfilesService)
        {
            _tblPerfilesService = tblPerfilesService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblPerfilesDTO perfiles)
        {
            try
            {
                await _tblPerfilesService.Crear(perfiles);
                return StatusCode(201, new { message = "Perfil creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPerfilesDTO perfiles)
        {
            try
            {
                await _tblPerfilesService.Actualizar(perfiles);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblPerfilesDTO dto)
        {
            try
            {
                await _tblPerfilesService.Eliminar(dto.lPerfiles_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idPerfiles}")]
        public async Task<ActionResult> ObtenerPorId(int idPerfiles)
        {
            try
            {
                var perfiles = await _tblPerfilesService.ObtenerPorId(idPerfiles);
                if (perfiles == null) return NotFound(new { message = $"El perfil con Id {idPerfiles} no existe" });
                return Ok(perfiles);
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
                return Ok(await _tblPerfilesService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
