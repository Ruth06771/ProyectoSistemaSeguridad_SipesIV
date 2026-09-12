using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblCentroAlertasRepository
    {
        public Task<int> Crear(TblCentroAlertas centroalertas);
        public Task<int> Actualizar(TblCentroAlertas centroalertas);
        public Task<int> Eliminar(int idCentroAlertas);
        public Task<TblCentroAlertas> ObtenerPorId(int idCentroAlertas);
        public Task<List<TblCentroAlertas>> ObtenerCentrosAlertas();
    }
}
