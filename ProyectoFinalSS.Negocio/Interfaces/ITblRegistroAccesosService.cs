using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblRegistroAccesos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblRegistroAccesosService
    {
        public Task Crear(CreateTblRegistroAccesosDTO RegistroAccesos);
        public Task Actualizar(UpdateTblRegistroAccesosDTO RegistroAccesos);
        public Task Eliminar(int idRegistroAccesos);
        public Task<ReadTblRegistroAccesosDTO> ObtenerPorId(int idRegistroAccesos);
        public Task<List<ReadTblRegistroAccesosDTO>> ObtenerTodos();
    }
}
