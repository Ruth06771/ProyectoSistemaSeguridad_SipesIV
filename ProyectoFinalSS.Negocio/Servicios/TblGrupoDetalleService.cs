using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblGrupoDetalle;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblGrupoDetalleService : ITblGrupoDetalleService
    {
        private readonly ITblGrupoDetalleRepository _tblGrupoDetalleRepository;
        public TblGrupoDetalleService(ITblGrupoDetalleRepository tblGrupoDetalleRepository)
        {
            _tblGrupoDetalleRepository = tblGrupoDetalleRepository;
        }
        public async Task Crear(CreateTblGrupoDetalleDTO tblGrupoDetalle)
        {
            TblGrupoDetalle objTblGrupoDetalle = new TblGrupoDetalle
            {
                lPersonas_id = tblGrupoDetalle.lPersonas_id,
                lGrupo_id = tblGrupoDetalle.lGrupo_id,
                sGrupoDetalle_fecha = tblGrupoDetalle.sGrupoDetalle_fecha,
                sGrupoDetalle_tipo = tblGrupoDetalle.sGrupoDetalle_tipo,
                sGrupoDetalle_estado = tblGrupoDetalle.sGrupoDetalle_estado
            };
            await _tblGrupoDetalleRepository.Crear(objTblGrupoDetalle);
        }

        public async Task Actualizar(UpdateTblGrupoDetalleDTO tblGrupoDetalle)
        {
            TblGrupoDetalle objTblGrupoDetalle = new TblGrupoDetalle
            {
                lGrupoDetalle_id = tblGrupoDetalle.lGrupoDetalle_id,
                lPersonas_id = tblGrupoDetalle.lPersonas_id,
                lGrupo_id = tblGrupoDetalle.lGrupo_id,
                sGrupoDetalle_fecha = tblGrupoDetalle.sGrupoDetalle_fecha,
                sGrupoDetalle_tipo = tblGrupoDetalle.sGrupoDetalle_tipo,
                sGrupoDetalle_estado = tblGrupoDetalle.sGrupoDetalle_estado
            };
            await _tblGrupoDetalleRepository.Actualizar(objTblGrupoDetalle);
        }

        public async Task Eliminar(int idGrupoDetalle)
        {
            await _tblGrupoDetalleRepository.Eliminar(idGrupoDetalle);
        }

        public async Task<ReadTblGrupoDetalleDTO> ObtenerPorId(int idGrupoDetalle)
        {
            var result = await _tblGrupoDetalleRepository.ObtenerPorId(idGrupoDetalle);
            if (result is null) return null;
            return new ReadTblGrupoDetalleDTO
            {
                lGrupoDetalle_id = result.lGrupoDetalle_id,
                lPersonas_id = result.lPersonas_id,
                lGrupo_id = result.lGrupo_id,
                sGrupoDetalle_fecha = result.sGrupoDetalle_fecha,
                sGrupoDetalle_tipo = result.sGrupoDetalle_tipo,
                sGrupoDetalle_estado = result.sGrupoDetalle_estado
            };
        }

        public async Task<List<ReadTblGrupoDetalleDTO>> ObtenerTodos()
        {
            var tblGrupoDetalles = await _tblGrupoDetalleRepository.ObtenerTodos();
            var TblGrupoDetallesDTO = new List<ReadTblGrupoDetalleDTO>();

            foreach (var tblGrupoDetalle in tblGrupoDetalles)
            {
                var tblGrupoDetalleDTO = new ReadTblGrupoDetalleDTO
                {
                    lGrupoDetalle_id = tblGrupoDetalle.lGrupoDetalle_id,
                    lPersonas_id = tblGrupoDetalle.lPersonas_id,
                    lGrupo_id = tblGrupoDetalle.lGrupo_id,
                    sGrupoDetalle_fecha = tblGrupoDetalle.sGrupoDetalle_fecha,
                    sGrupoDetalle_tipo = tblGrupoDetalle.sGrupoDetalle_tipo,
                    sGrupoDetalle_estado = tblGrupoDetalle.sGrupoDetalle_estado
                };
                TblGrupoDetallesDTO.Add(tblGrupoDetalleDTO);
            }

            return TblGrupoDetallesDTO;
        }
    }
}