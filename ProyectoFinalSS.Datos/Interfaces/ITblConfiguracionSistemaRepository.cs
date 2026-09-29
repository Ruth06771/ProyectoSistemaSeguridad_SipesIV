using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblConfiguracionSistemaRepository
    {
        public Task<int> Crear(TblConfiguracionSistema ConfiguracionSistema);
        public Task<int> Actualizar(TblConfiguracionSistema ConfiguracionSistema);
        public Task<int> Eliminar(int idConfiguracionSistema);
        public Task<TblArea> ObtenerPorId(int idConfiguracionSistema);
        public Task<List<TblArea>> ObtenerTodos();
    }
}
