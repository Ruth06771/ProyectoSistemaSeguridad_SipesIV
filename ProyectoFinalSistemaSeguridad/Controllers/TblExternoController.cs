using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblExterno;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblExternoController : ControllerBase
    {
        private readonly ITblExternoService _tblExternoService;
        public TblExternoController(ITblExternoService tblExternoService)
        {
            _tblExternoService = tblExternoService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblExternoDTO externo)
        {
            try
            {
                await _tblExternoService.Crear(externo);
                return StatusCode(201, new { message = "Externo creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblExternoDTO externo)
        {
            try
            {
                await _tblExternoService.Actualizar(externo);
                return StatusCode(201, new { message = "Externo actualizado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblExternoDTO dto)
        {
            try
            {
                await _tblExternoService.Eliminar(dto.lGrupo_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idExterno}")]
        public async Task<ActionResult> ObtenerPorId(int idExterno)
        {
            try
            {
                var externo = await _tblExternoService.ObtenerPorId(idExterno);
                if (externo == null) return NotFound(new { message = $"El externo con Id {idExterno} no existe" });
                return Ok(externo);
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
                return Ok(await _tblExternoService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
