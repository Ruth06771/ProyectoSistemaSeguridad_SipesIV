using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblContactoEmergencia;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblContactoEmergenciaController : ControllerBase
    {
        private readonly ITblContactoEmergenciaService _tblContactoEmergenciaService;
        public TblContactoEmergenciaController(ITblContactoEmergenciaService tblContactoEmergenciaService)
        {
            _tblContactoEmergenciaService = tblContactoEmergenciaService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblContactoEmergenciaDTO ContactoEmergencia)
        {
            try
            {
                await _tblContactoEmergenciaService.Crear(ContactoEmergencia);
                return StatusCode(201, new { message = "Contacto de emergencia creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblContactoEmergenciaDTO ContactoEmergencia)
        {
            try
            {
                await _tblContactoEmergenciaService.Actualizar(ContactoEmergencia);
                return StatusCode(201, new { message = "Contacto de emergencia actualizado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblContactoEmergenciaDTO dto)
        {
            try
            {
                await _tblContactoEmergenciaService.Eliminar(dto.lContacto_emerg_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idContacto}")]
        public async Task<ActionResult> ObtenerPorId(int idContactoEmergencia)
        {
            try
            {
                var contacto = await _tblContactoEmergenciaService.ObtenerPorId(idContactoEmergencia);
                if (contacto == null) return NotFound(new { message = $"El contacto de emergencia con Id {idContactoEmergencia} no existe" });
                return Ok(contacto);
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
                return Ok(await _tblContactoEmergenciaService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
