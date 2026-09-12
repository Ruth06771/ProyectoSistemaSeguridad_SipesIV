using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblPerfilesRepository
    {
        public Task<int> Crear(TblPerfiles perfiles);
        public Task<int> Actualizar(TblPerfiles perfiles);
        public Task<int> Eliminar(int idPerfiles);
        public Task<TblPerfiles> ObtenerPorId(int idPerfiles);
        public Task<List<TblPerfiles>> ObtenerPerfiles();
    }
}
