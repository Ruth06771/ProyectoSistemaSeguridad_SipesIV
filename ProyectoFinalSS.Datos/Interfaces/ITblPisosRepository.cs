using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblPisosRepository
    {
        public Task<int> Crear(TblPisos pisos);
        public Task<int> Actualizar(TblPisos pisos);
        public Task<int> Eliminar(int idPisos);
        public Task<TblPisos> ObtenerPorId(int idPisos);
        public Task<List<TblPisos>> ObtenerTodos();
    }
}
