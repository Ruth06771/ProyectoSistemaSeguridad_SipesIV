using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblAsistenciaReservaTipoRepository
    {
        public Task<int> Crear(TblAsistenciaReservaTipo asistenciaReservaTipo);
        public Task<int> Actualizar(TblAsistenciaReservaTipo asistenciaReservaTipo);
        public Task<int> Eliminar(int idAsistenciaReservaTipo);
        public Task<TblAsistenciaReservaTipo> ObtenerPorId(int idAsistenciaReservaTipo);
        public Task<List<TblAsistenciaReservaTipo>> ObtenerAsistenciasReservasTipos();
    }
}
