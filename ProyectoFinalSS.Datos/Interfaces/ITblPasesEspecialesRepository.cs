using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblPasesEspecialesRepository
    {
        public Task<int> Crear(TblPasesEspeciales pasesEspeciales);
        public Task<int> Actualizar(TblPasesEspeciales pasesEspeciales);
        public Task<int> Eliminar(int idPasesEspeciales);
        public Task<TblPasesEspeciales> ObtenerPorId(int idPasesEspeciales);
        public Task<List<TblPasesEspeciales>> ObtenerTodos();
    }
}
