using Microsoft.AspNetCore.Mvc;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.DTOs.TblUsuarios;
using ProyectoFinalSS.Negocio.Interfaces;

namespace ProyectoFinalSistemaSeguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblUsuariosController : ControllerBase
    {
        private readonly ITblUsuariosService _tblUsuariosService;
        public TblUsuariosController(ITblUsuariosService tblUsuariosService)
        {
            _tblUsuariosService = tblUsuariosService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblUsuariosDTO usuarios)
        {
            try
            {
                await _tblUsuariosService.Crear(usuarios);
                return StatusCode(201, new { message = "Usuario creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblUsuariosDTO usuarios)
        {
            try
            {
                await _tblUsuariosService.Actualizar(usuarios);
                return StatusCode(201, new { message = "Actualizado correctamente" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar([FromBody] DeleteTblUsuarioDTO dto)
        {
            try
            {
                await _tblUsuariosService.Eliminar(dto.lUsuarios_id);
                return Ok(new { message = "Eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("ObtenerPorId/{idUsuarios}")]
        public async Task<ActionResult> ObtenerPorId(int idUsuarios)
        {
            try
            {
                var usuarios = await _tblUsuariosService.ObtenerPorId(idUsuarios);
                if (usuarios == null) return NotFound(new { message = $"El usuario con Id {idUsuarios} no existe" });
                return Ok(usuarios);
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
                return Ok(await _tblUsuariosService.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
