using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblGrupoDetalle;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblGrupoDetalleController : ControllerBase
    {
        private readonly ITblGrupoDetalleService _tblGrupoDetalleService;
        public TblGrupoDetalleController(ITblGrupoDetalleService tblGrupoDetalleService)
        {
            _tblGrupoDetalleService = tblGrupoDetalleService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblGrupoDetalleDTO GrupoDetalle)
        {
            try
            {
                await _tblGrupoDetalleService.Crear(GrupoDetalle);
                return StatusCode(201, new { message = "Grupo detalle creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblGrupoDetalleDTO GrupoDetalle)
        {
            try
            {
                await _tblGrupoDetalleService.Actualizar(GrupoDetalle);
                return StatusCode(201, new { message = "Grupo detalle actualizado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblGrupoDetalleDTO dto)
        {
            try
            {
                await _tblGrupoDetalleService.Eliminar(dto.lGrupoDetalle_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idGrupoDetalle}")]
        public async Task<ActionResult> ObtenerPorId(int idGrupoDetalle)
        {
            try
            {
                var grupoDetalle = await _tblGrupoDetalleService.ObtenerPorId(idGrupoDetalle);
                if (grupoDetalle == null) return NotFound(new { message = $"El grupo detalle con Id {idGrupoDetalle} no existe" });
                return Ok(grupoDetalle);
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
                return Ok(await _tblGrupoDetalleService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
