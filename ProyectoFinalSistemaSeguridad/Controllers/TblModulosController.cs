using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblMaterias;
using ProyectoFinalSS.Negocio.DTOs.TblModulos;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblModulosController : ControllerBase
    {
        private readonly ITblModulosService _tblModulosService;
        public TblModulosController(ITblModulosService tblModulosService)
        {
            _tblModulosService = tblModulosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblModulosDTO modulos)
        {
            try
            {
                await _tblModulosService.Crear(modulos);
                return StatusCode(201, new { message = "Módulo creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblModulosDTO modulos)
        {
            try
            {
                await _tblModulosService.Actualizar(modulos);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblModulosDTO dto)
        {
            try
            {
                await _tblModulosService.Eliminar(dto.lModulo_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idModulo}")]
        public async Task<ActionResult> ObtenerPorId(int idModulos)
        {
            try
            {
                var modulo = await _tblModulosService.ObtenerPorId(idModulos);
                if (modulo == null) return NotFound(new { message = $"El módulo con Id {idModulos} no existe" });
                return Ok(modulo);
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
                return Ok(await _tblModulosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
