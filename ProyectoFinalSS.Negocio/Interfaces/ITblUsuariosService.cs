using ProyectoFinalSS.Negocio.DTOs.TblUsuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblUsuariosService
    {
        public Task Crear(CreateTblUsuariosDTO usuariosDTO);
        public Task Actualizar(UpdateTblUsuariosDTO usuariosDTO);
        public Task Eliminar(int lUsuario_id);
        public Task<ReadTblUsuariosDTO> ObtenerPorId(int lUsuario_id);
        public Task<List<ReadTblUsuariosDTO>> ObtenerTodos();
    }
}
