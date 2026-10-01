using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblGrupo;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblGrupoController : ControllerBase
    {
        private readonly ITblGrupoService _tblGrupoService;
        public TblGrupoController(ITblGrupoService tblGrupoService)
        {
            _tblGrupoService = tblGrupoService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblGrupoDTO grupo)
        {
            try
            {
                await _tblGrupoService.Crear(grupo);
                return StatusCode(201, new { message = "Grupo creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblGrupoDTO grupo)
        {
            try
            {
                await _tblGrupoService.Actualizar(grupo);
                return StatusCode(201, new { message = "Grupo actualizado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblGrupoDTO dto)
        {
            try
            {
                await _tblGrupoService.Eliminar(dto.lGrupo_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idGrupo}")]
        public async Task<ActionResult> ObtenerPorId(int idGrupo)
        {
            try
            {
                var grupo = await _tblGrupoService.ObtenerPorId(idGrupo);
                if (grupo == null) return NotFound(new { message = $"El grupo con Id {idGrupo} no existe" });
                return Ok(grupo);
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
                return Ok(await _tblGrupoService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
