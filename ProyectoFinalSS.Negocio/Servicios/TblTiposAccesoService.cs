using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblTiposAcceso;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblTiposAccesoService : ITblTiposAccesoService
    {
        private readonly ITblTiposAccesoRepository _tblTiposAccesoRepository;
        public TblTiposAccesoService(ITblTiposAccesoRepository tblTiposAccesoRepository)
        {
            _tblTiposAccesoRepository = tblTiposAccesoRepository;
        }
        public async Task Crear(CreateTblTiposAccessoDTO tblTiposAcceso)
        {
            TblTiposAccesos objTblTiposAcceso = new TblTiposAccesos
            {
                sTRegistro_nombre = tblTiposAcceso.sTRegistro_nombre,
                sTRegistro_estado = tblTiposAcceso.sTRegistro_estado
            };
            await _tblTiposAccesoRepository.Crear(objTblTiposAcceso);
        }

        public async Task Actualizar(UpdateTblTiposAccesoDTO tblTiposAcceso)
        {
            TblTiposAccesos objTblTiposAcceso = new TblTiposAccesos
            {
                lTRegistro_id = tblTiposAcceso.lTRegistro_id,
                sTRegistro_nombre = tblTiposAcceso.sTRegistro_nombre,
                sTRegistro_estado = tblTiposAcceso.sTRegistro_estado
            };
            await _tblTiposAccesoRepository.Actualizar(objTblTiposAcceso);
        }

        public async Task Eliminar(int idTiposAcceso)
        {
            await _tblTiposAccesoRepository.Eliminar(idTiposAcceso);
        }

        public async Task<ReadTblTiposAccesoDTO> ObtenerPorId(int idTiposAcceso)
        {
            var result = await _tblTiposAccesoRepository.ObtenerPorId(idTiposAcceso);
            if (result is null) return null;
            return new ReadTblTiposAccesoDTO
            {
                lTRegistro_id = result.lTRegistro_id,
                sTRegistro_nombre = result.sTRegistro_nombre,
                sTRegistro_estado = result.sTRegistro_estado
            };
        }

        public async Task<List<ReadTblTiposAccesoDTO>> ObtenerTodos()
        {
            var tblTiposAccesos = await _tblTiposAccesoRepository.ObtenerTodos();
            var TblTiposAccesosDTO = new List<ReadTblTiposAccesoDTO>();

            foreach (var tblTiposAcceso in tblTiposAccesos)
            {
                var tblTiposAccesoDTO = new ReadTblTiposAccesoDTO
                {
                    lTRegistro_id = tblTiposAcceso.lTRegistro_id,
                    sTRegistro_nombre = tblTiposAcceso.sTRegistro_nombre,
                    sTRegistro_estado = tblTiposAcceso.sTRegistro_estado
                };
                TblTiposAccesosDTO.Add(tblTiposAccesoDTO);
            }

            return TblTiposAccesosDTO;
        }
    }
}
