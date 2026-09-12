using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblPersonasRepository
    {
        public Task<int> Crear(TblPersonas personas);
        public Task<int> Actualizar(TblPersonas personas);
        public Task<int> Eliminar(int idPersonas);
        public Task<TblPersonas> ObtenerPorId(int idPersonas);
        public Task<List<TblPersonas>> ObtenerPersonas();
    }
}
