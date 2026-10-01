using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblAccesoPersona;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAccesoPersonaController : ControllerBase
    {
        private readonly ITblAccesoPersonaService _tblAccesoPersonaService;
        public TblAccesoPersonaController(ITblAccesoPersonaService tblAccesoPersonaService)
        {
            _tblAccesoPersonaService = tblAccesoPersonaService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblAccesoPersonaDTO AccesoPersona)
        {
            try
            {
                await _tblAccesoPersonaService.Crear(AccesoPersona);
                return StatusCode(201, new { message = "Creada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblAccesoPersonaDTO AccesoPersona)
        {
            try
            {
                await _tblAccesoPersonaService.Actualizar(AccesoPersona);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblAccesoPersonaDTO dto)
        {
            try
            {
                await _tblAccesoPersonaService.Eliminar(dto.lTRegis_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idAccesoPersona}")]
        public async Task<ActionResult> ObtenerPorId(int idAccesoPersona)
        {
            try
            {
                var accesoPersona = await _tblAccesoPersonaService.ObtenerPorId(idAccesoPersona);
                if (accesoPersona == null) return NotFound(new { message = $"El acceso persona con Id {idAccesoPersona} no existe" });
                return Ok(accesoPersona);
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
                return Ok(await _tblAccesoPersonaService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
