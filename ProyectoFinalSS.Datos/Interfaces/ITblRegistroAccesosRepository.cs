using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblRegistroAccesosRepository
    {
        public Task<int> Crear(TblRegistroAccesos RegistroAcceso);
        public Task<int> Actualizar(TblRegistroAccesos RegistroAcceso);
        public Task<int> Eliminar(int idRegistroAcceso);
        public Task<TblRegistroAccesos> ObtenerPorId(int idRegistroAcceso);
        public Task<List<TblRegistroAccesos>> ObtenerTodos();
    }
}
