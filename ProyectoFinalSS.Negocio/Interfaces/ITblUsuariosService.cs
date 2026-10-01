using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblUsuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblUsuariosService
    {
        public Task Crear(CreateTblUsuariosDTO usuarios);
        public Task Actualizar(UpdateTblUsuariosDTO usuarios);
        public Task Eliminar(int idUsuarios);
        public Task<ReadTblUsuariosDTO> ObtenerPorId(int idUsuarios);
        public Task<List<ReadTblUsuariosDTO>> ObtenerTodos();
    }
}
