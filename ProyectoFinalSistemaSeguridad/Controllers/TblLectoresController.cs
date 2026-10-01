using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblLectores;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblLectoresController : ControllerBase
    {
        private readonly ITblLectoresService _tblLectoresService;
        public TblLectoresController(ITblLectoresService tblLectoresService)
        {
            _tblLectoresService = tblLectoresService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblLectoresDTO lectores)
        {
            try
            {
                await _tblLectoresService.Crear(lectores);
                return StatusCode(201, new { message = "Lector creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblLectoresDTO lectores)
        {
            try
            {
                await _tblLectoresService.Actualizar(lectores);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblLectoresDTO dto)
        {
            try
            {
                await _tblLectoresService.Eliminar(dto.lLector_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idLector}")]
        public async Task<ActionResult> ObtenerPorId(int idLectores)
        {
            try
            {
                var lectores = await _tblLectoresService.ObtenerPorId(idLectores);
                if (lectores == null) return NotFound(new { message = $"El lector con Id {idLectores} no existe" });
                return Ok(lectores);
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
                return Ok(await _tblLectoresService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
