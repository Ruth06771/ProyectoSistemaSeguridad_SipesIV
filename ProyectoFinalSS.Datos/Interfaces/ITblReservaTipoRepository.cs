using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblReservaTipoRepository
    {
        public Task<int> Crear(TblReservaTipo reservaTipo);
        public Task<int> Actualizar(TblReservaTipo reservaTipo);
        public Task<int> Eliminar(int idReservaTipo);
        public Task<TblReservaTipo> ObtenerPorId(int idReservaTipo);
        public Task<List<TblReservaTipo>> ObtenerReservasTipos();
    }
}
