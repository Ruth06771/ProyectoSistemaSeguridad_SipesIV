using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblReservaExtraordinariaRepository
    {
        public Task<int> Crear(TblReservaExtraordinaria reservaextraordinaria);
        public Task<int> Actualizar(TblReservaExtraordinaria reservaextraordinaria);
        public Task<int> Eliminar(int idReservaExtraordinaria);
        public Task<TblReservaExtraordinaria> ObtenerPorId(int idReservaExtraordinaria);
        public Task<List<TblReservaExtraordinaria>> ObtenerReservasExtraordinarias();
    }
}
