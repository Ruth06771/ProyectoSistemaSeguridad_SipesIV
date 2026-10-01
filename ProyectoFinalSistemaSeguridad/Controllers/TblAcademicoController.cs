using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAcademicoController : ControllerBase
    {
        private readonly ITblAcademicoService _tblAcademicoService;
        public TblAcademicoController(ITblAcademicoService tblAcademicoService)
        {
            _tblAcademicoService = tblAcademicoService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblAcademicoDTO academico)
        {
            try
            {
                await _tblAcademicoService.Crear(academico);
                return StatusCode(201, new { message = "Academico creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblAcademicoDTO academico)
        {
            try
            {
                await _tblAcademicoService.Actualizar(academico);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblAcademicoDto dto)
        {
            try
            {
                await _tblAcademicoService.Eliminar(dto.lGrupo_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idAcademico}")]
        public async Task<ActionResult> ObtenerPorId(int idAcademico)
        {
            try
            {
                var academico = await _tblAcademicoService.ObtenerPorId(idAcademico);
                if (academico == null) return NotFound(new { message = $"El academico con Id {idAcademico} no existe" });
                return Ok(academico);
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
                return Ok(await _tblAcademicoService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
