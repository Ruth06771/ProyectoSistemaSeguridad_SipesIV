using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblLogsSistemaRepository
    {
        public Task<int> Crear(TblLogsSistema LogsSistema);
        public Task<int> Actualizar(TblLogsSistema LogsSistema);
        public Task<int> Eliminar(int idLogsSistema);
        public Task<TblLogsSistema> ObtenerPorId(int idLogsSistema);
        public Task<List<TblLogsSistema>> ObtenerTodos();
    }
}
