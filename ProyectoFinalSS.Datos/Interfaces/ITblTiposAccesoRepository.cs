using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblTiposAccesoRepository
    {
        public Task<int> Crear(TblTiposAccesos TiposAcceso);
        public Task<int> Actualizar(TblTiposAccesos TiposAcceso);
        public Task<int> Eliminar(int idTiposAcceso);
        public Task<TblTiposAccesos> ObtenerPorId(int idTiposAcceso);
        public Task<List<TblTiposAccesos>> ObtenerTodos();
    }
}
