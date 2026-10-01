using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblEdificio;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEdificioController : ControllerBase
    {
        private readonly ITblEdificiosService _tblEdificiosService;
        public TblEdificioController(ITblEdificiosService tblEdificiosService)
        {
            _tblEdificiosService = tblEdificiosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblEdificioDTO edificios)
        {
            try
            {
                await _tblEdificiosService.Crear(edificios);
                return StatusCode(201, new { message = "Edificio creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblEdificioDTO edificios)
        {
            try
            {
                await _tblEdificiosService.Actualizar(edificios);
                return StatusCode(201, new { message = "Edificio actualizado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblEdificioDTO dto)
        {
            try
            {
                await _tblEdificiosService.Eliminar(dto.lEdificio_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idEdificios}")]
        public async Task<ActionResult> ObtenerPorId(int idEdificios)
        {
            try
            {
                var edificio = await _tblEdificiosService.ObtenerPorId(idEdificios);
                if (edificio == null) return NotFound(new { message = $"El edificio con Id {idEdificios} no existe" });
                return Ok(edificio);
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
                return Ok(await _tblEdificiosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
