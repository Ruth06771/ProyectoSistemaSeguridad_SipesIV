using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblBloqueadosRepository
    {
        public Task<int> Crear(TblBloqueados bloqueados);
        public Task<int> Actualizar(TblBloqueados bloqueados);
        public Task<int> Eliminar(int idbloqueados);
        public Task<TblBloqueados> ObtenerPorId(int idbloqueados);
        public Task<List<TblBloqueados>> ObtenerTodos();
    }
}
