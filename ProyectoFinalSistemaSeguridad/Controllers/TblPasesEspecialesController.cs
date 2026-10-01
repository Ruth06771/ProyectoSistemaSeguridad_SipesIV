using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblPasesEspeciales;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPasesEspecialesController : ControllerBase
    {
        private readonly ITblPasesEspecialesService _tblPasesEspecialesService;
        public TblPasesEspecialesController(ITblPasesEspecialesService tblPasesEspecialesService)
        {
            _tblPasesEspecialesService = tblPasesEspecialesService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblPasesEspecialesDTO PasesEspeciales)
        {
            try
            {
                await _tblPasesEspecialesService.Crear(PasesEspeciales);
                return StatusCode(201, new { message = "Pase especial creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPasesEspecialesDTO PasesEspeciales)
        {
            try
            {
                await _tblPasesEspecialesService.Actualizar(PasesEspeciales);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblPasesEspecialesDTO dto)
        {
            try
            {
                await _tblPasesEspecialesService.Eliminar(dto.lPasesEspeciales_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idPasesEspeciales}")]
        public async Task<ActionResult> ObtenerPorId(int idPasesEspeciales)
        {
            try
            {
                var pasesEspeciales = await _tblPasesEspecialesService.ObtenerPorId(idPasesEspeciales);
                if (pasesEspeciales == null) return NotFound(new { message = $"El pase especial con Id {idPasesEspeciales} no existe" });
                return Ok(pasesEspeciales);
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
                return Ok(await _tblPasesEspecialesService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
