using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblEdificiosRepository
    {
        public Task<int> Crear(TblEdificios edificios);
        public Task<int> Actualizar(TblEdificios edificios);
        public Task<int> Eliminar(int idEdificios);
        public Task<TblEdificios> ObtenerPorId(int idEdificios);
        public Task<List<TblEdificios>> ObtenerTodos();
    }
}
