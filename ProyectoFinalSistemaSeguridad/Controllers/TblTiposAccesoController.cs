using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblTiposAcceso;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblTiposAccesoController : ControllerBase
    {
        private readonly ITblTiposAccesoService _tblTiposAccesoService;
        public TblTiposAccesoController(ITblTiposAccesoService tblTiposAccesoService)
        {
            _tblTiposAccesoService = tblTiposAccesoService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblTiposAccessoDTO TiposAcceso)
        {
            try
            {
                await _tblTiposAccesoService.Crear(TiposAcceso);
                return StatusCode(201, new { message = "Tipo de acceso creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblTiposAccesoDTO TiposAcceso)
        {
            try
            {
                await _tblTiposAccesoService.Actualizar(TiposAcceso);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblTiposAccesoDTO dto)
        {
            try
            {
                await _tblTiposAccesoService.Eliminar(dto.lTRegistro_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idTipos_Acceso}")]
        public async Task<ActionResult> ObtenerPorId(int idTipos_Acceso)
        {
            try
            {
                var tiposAcceso = await _tblTiposAccesoService.ObtenerPorId(idTipos_Acceso);
                if (tiposAcceso == null) return NotFound(new { message = $"El tipo de acceso con Id {idTipos_Acceso} no existe" });
                return Ok(tiposAcceso);
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
                return Ok(await _tblTiposAccesoService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
