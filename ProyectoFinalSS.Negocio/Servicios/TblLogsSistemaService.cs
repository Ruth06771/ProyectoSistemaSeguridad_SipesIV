using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblLogsSistema;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblLogsSistemaService : ITblLogsSistemaService
    {
        private readonly ITblLogsSistemaRepository _tblLogsSistemaRepository;
        public TblLogsSistemaService(ITblLogsSistemaRepository tblLogsSistemaRepository)
        {
            _tblLogsSistemaRepository = tblLogsSistemaRepository;
        }
        public async Task Crear(CreateTblLogsSistemaDTO tblLogsSistema)
        {
            TblLogsSistema objTblLogsSistema = new TblLogsSistema
            {
                lUsuario_id = tblLogsSistema.lUsuario_id,
                sLog_modulo = tblLogsSistema.sLog_modulo,
                sLog_accion = tblLogsSistema.sLog_accion,
                sLog_detalle = tblLogsSistema.sLog_detalle,
                sLog_origen = tblLogsSistema.sLog_origen,
                sLog_fecha_origen = tblLogsSistema.sLog_fecha_origen
            };
            await _tblLogsSistemaRepository.Crear(objTblLogsSistema);
        }

        public async Task Actualizar(UpdateTblLogsSistemaDTO tblLogsSistema)
        {
            TblLogsSistema objTblLogsSistema = new TblLogsSistema
            {
                lLog_id = tblLogsSistema.lLog_id,
                lUsuario_id = tblLogsSistema.lUsuario_id,
                sLog_modulo = tblLogsSistema.sLog_modulo,
                sLog_accion = tblLogsSistema.sLog_accion,
                sLog_detalle = tblLogsSistema.sLog_detalle,
                sLog_origen = tblLogsSistema.sLog_origen,
                sLog_fecha_origen = tblLogsSistema.sLog_fecha_origen
            };
            await _tblLogsSistemaRepository.Actualizar(objTblLogsSistema);
        }

        public async Task Eliminar(int idLogsSistema)
        {
            await _tblLogsSistemaRepository.Eliminar(idLogsSistema);
        }

        public async Task<ReadTblLogsSistemaDTO> ObtenerPorId(int idLogsSistema)
        {
            var result = await _tblLogsSistemaRepository.ObtenerPorId(idLogsSistema);
            if (result is null) return null;
            return new ReadTblLogsSistemaDTO
            {
                lLog_id = result.lLog_id,
                lUsuario_id = result.lUsuario_id,
                sLog_modulo = result.sLog_modulo,
                sLog_accion = result.sLog_accion,
                sLog_detalle = result.sLog_detalle,
                sLog_origen = result.sLog_origen,
                sLog_fecha_origen = result.sLog_fecha_origen
            };
        }

        public async Task<List<ReadTblLogsSistemaDTO>> ObtenerTodos()
        {
            var tblLogsSistemas = await _tblLogsSistemaRepository.ObtenerTodos();
            var TblLogsSistemasDTO = new List<ReadTblLogsSistemaDTO>();

            foreach (var tblLogsSistema in tblLogsSistemas)
            {
                var tblLogsSistemaDTO = new ReadTblLogsSistemaDTO
                {
                    lLog_id = tblLogsSistema.lLog_id,
                    lUsuario_id = tblLogsSistema.lUsuario_id,
                    sLog_modulo = tblLogsSistema.sLog_modulo,
                    sLog_accion = tblLogsSistema.sLog_accion,
                    sLog_detalle = tblLogsSistema.sLog_detalle,
                    sLog_origen = tblLogsSistema.sLog_origen,
                    sLog_fecha_origen = tblLogsSistema.sLog_fecha_origen
                };
                TblLogsSistemasDTO.Add(tblLogsSistemaDTO);
            }

            return TblLogsSistemasDTO;
        }
    }
}
