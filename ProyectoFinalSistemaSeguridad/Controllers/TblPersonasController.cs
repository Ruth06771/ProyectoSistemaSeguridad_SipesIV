using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblPersonas;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPersonasController : ControllerBase
    {
        private readonly ITblPersonasService _tblPersonasService;
        public TblPersonasController(ITblPersonasService tblPersonasService)
        {
            _tblPersonasService = tblPersonasService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblPersonasDTO personas)
        {
            try
            {
                await _tblPersonasService.Crear(personas);
                return StatusCode(201, new { message = "Persona creada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPersonasDTO personas)
        {
            try
            {
                await _tblPersonasService.Actualizar(personas);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblPersonasDTO dto)
        {
            try
            {
                await _tblPersonasService.Eliminar(dto.lPersonas_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idPersonas}")]
        public async Task<ActionResult> ObtenerPorId(int idPersonas)
        {
            try
            {
                var personas = await _tblPersonasService.ObtenerPorId(idPersonas);
                if (personas == null) return NotFound(new { message = $"La persona con Id {idPersonas} no existe" });
                return Ok(personas);
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
                return Ok(await _tblPersonasService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
