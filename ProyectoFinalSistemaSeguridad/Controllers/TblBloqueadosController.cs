using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblBloqueados;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblBloqueadosController : ControllerBase
    {
        private readonly ITblBloqueadosService _tblBloqueadosService;
        public TblBloqueadosController(ITblBloqueadosService tblBloqueadosService)
        {
            _tblBloqueadosService = tblBloqueadosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblBloqueadosDTO bloqueados)
        {
            try
            {
                await _tblBloqueadosService.Crear(bloqueados);
                return StatusCode(201, new { message = "Bloqueado creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblBloqueadosDTO bloqueados)
        {
            try
            {
                await _tblBloqueadosService.Actualizar(bloqueados);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblBloqueadosDTO dto)
        {
            try
            {
                await _tblBloqueadosService.Eliminar(dto.lBloqueados_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idbloqueados}")]
        public async Task<ActionResult> ObtenerPorId(int idbloqueados)
        {
            try
            {
                var bloqueados = await _tblBloqueadosService.ObtenerPorId(idbloqueados);
                if (bloqueados == null) return NotFound(new { message = $"El bloqueado con Id {idbloqueados} no existe" });
                return Ok(bloqueados);
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
                return Ok(await _tblBloqueadosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
