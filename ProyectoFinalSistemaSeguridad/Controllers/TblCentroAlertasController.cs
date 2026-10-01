using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblCentroAlertasController : ControllerBase
    {
        private readonly ITblCentroAlertasService _tblCentroAlertasService;
        public TblCentroAlertasController(ITblCentroAlertasService tblCentroAlertasService)
        {
            _tblCentroAlertasService = tblCentroAlertasService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblCentroAlertasDTO CentroAlertas)
        {
            try
            {
                await _tblCentroAlertasService.Crear(CentroAlertas);
                return StatusCode(201, new { message = "Centro de alertas creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblCentroAlertasDTO CentroAlertas)
        {
            try
            {
                await _tblCentroAlertasService.Actualizar(CentroAlertas);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblCentroAlertasDTO dto)
        {
            try
            {
                await _tblCentroAlertasService.Eliminar(dto.lCentroAlertas_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idCentroAlertas}")]
        public async Task<ActionResult> ObtenerPorId(int idCentroAlertas)
        {
            try
            {
                var centroAlertas = await _tblCentroAlertasService.ObtenerPorId(idCentroAlertas);
                if (centroAlertas == null) return NotFound(new { message = $"El centro de alertas con Id {idCentroAlertas} no existe" });
                return Ok(centroAlertas);
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
                return Ok(await _tblCentroAlertasService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
