using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblMaterias;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblMateriaController : ControllerBase
    {
        private readonly ITblMateriasService _tblMateriaService;
        public TblMateriaController(ITblMateriasService tblMateriaService)
        {
            _tblMateriaService = tblMateriaService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblMateriasDTO materias)
        {
            try
            {
                await _tblMateriaService.Crear(materias);
                return StatusCode(201, new { message = "Materia creada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblMateriasDTO materias)
        {
            try
            {
                await _tblMateriaService.Actualizar(materias);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblMateriasDTO dto)
        {
            try
            {
                await _tblMateriaService.Eliminar(dto.lMateria_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idMaterias}")]
        public async Task<ActionResult> ObtenerPorId(int idMaterias)
        {
            try
            {
                var materia = await _tblMateriaService.ObtenerPorId(idMaterias);
                if (materia == null) return NotFound(new { message = $"La materia con Id {idMaterias} no existe" });
                return Ok(materia);
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
                return Ok(await _tblMateriaService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
