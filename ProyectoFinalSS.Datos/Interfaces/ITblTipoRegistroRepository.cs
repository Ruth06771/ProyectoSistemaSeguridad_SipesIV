using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblTipoRegistroRepository
    {
        public Task<int> Crear(TblTipoRegistro tipoRegistro);
        public Task<int> Actualizar(TblTipoRegistro tipoRegistro);
        public Task<int> Eliminar(int idTipoRegistro);
        public Task<TblTipoRegistro> ObtenerPorId(int idTipoRegistro);
        public Task<List<TblTipoRegistro>> ObtenerTiposRegistros();
    }
}
