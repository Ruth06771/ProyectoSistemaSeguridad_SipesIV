using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblDetalleHorarioRepository
    {
        public Task<int> Crear(TblDetalleHorario DetalleHorario);
        public Task<int> Actualizar(TblDetalleHorario DetalleHorario);
        public Task<int> Eliminar(int idDetalleHorario);
        public Task<TblDetalleHorario> ObtenerPorId(int idDetalleHorario);
        public Task<List<TblDetalleHorario>> ObtenerTodos();
    }
}
