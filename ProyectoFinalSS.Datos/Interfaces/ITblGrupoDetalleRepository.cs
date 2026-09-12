using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblGrupoDetalleRepository
    {
        public Task<int> Crear(TblGrupoDetalle grupoDetalle);
        public Task<int> Actualizar(TblGrupoDetalle grupoDetalle);
        public Task<int> Eliminar(int idGrupoDetalle);
        public Task<TblGrupoDetalle> ObtenerPorId(int idGrupoDetalle);
        public Task<List<TblGrupoDetalle>> ObtenerTodos();
    }
}
