using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblMateriasRepository
    {
        public Task<int> Crear(TblMaterias materias);
        public Task<int> Actualizar(TblMaterias materias);
        public Task<int> Eliminar(int idMaterias);
        public Task<TblMaterias> ObtenerPorId(int idMaterias);
        public Task<List<TblMaterias>> ObtenerTodos();
    }
}
