using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblBloqueados;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblBloqueadosService : ITblBloqueadosService
    {
        private readonly ITblBloqueadosRepository _tblBloqueadosRepository;
        public TblBloqueadosService(ITblBloqueadosRepository tblBloqueadosRepository)
        {
            _tblBloqueadosRepository = tblBloqueadosRepository;
        }
        public async Task Crear(CreateTblBloqueadosDTO tblBloqueados)
        {
            TblBloqueados objTblBloqueados = new TblBloqueados
            {
                lPersonas_id = tblBloqueados.lPersonas_id,
                sBloqueado_fecha_inicio = tblBloqueados.sBloqueado_fecha_inicio,
                sBloqueado_estado = tblBloqueados.sBloqueado_estado,
                sBloqueado_motivo = tblBloqueados.sBloqueado_motivo,
                sBloqueado_fecha_fin = tblBloqueados.sBloqueado_fecha_fin
            };
            await _tblBloqueadosRepository.Crear(objTblBloqueados);
        }

        public async Task Actualizar(UpdateTblBloqueadosDTO tblBloqueados)
        {
            TblBloqueados objTblBloqueados = new TblBloqueados
            {
                lBloqueados_id = tblBloqueados.lBloqueados_id,
                lPersonas_id = tblBloqueados.lPersonas_id,
                sBloqueado_fecha_inicio = tblBloqueados.sBloqueado_fecha_inicio,
                sBloqueado_estado = tblBloqueados.sBloqueado_estado,
                sBloqueado_motivo = tblBloqueados.sBloqueado_motivo,
                sBloqueado_fecha_fin = tblBloqueados.sBloqueado_fecha_fin
            };
            await _tblBloqueadosRepository.Actualizar(objTblBloqueados);
        }

        public async Task Eliminar(int idbloqueados)
        {
            await _tblBloqueadosRepository.Eliminar(idbloqueados);
        }

        public async Task<ReadTblBloqueadosDTO> ObtenerPorId(int idbloqueados)
        {
            var result = await _tblBloqueadosRepository.ObtenerPorId(idbloqueados);
            if (result is null) return null;
            return new ReadTblBloqueadosDTO
            {
                lBloqueados_id = result.lBloqueados_id,
                lPersonas_id = result.lPersonas_id,
                sBloqueado_fecha_inicio = result.sBloqueado_fecha_inicio,
                sBloqueado_estado = result.sBloqueado_estado,
                sBloqueado_motivo = result.sBloqueado_motivo,
                sBloqueado_fecha_fin = result.sBloqueado_fecha_fin
            };
        }

        public async Task<List<ReadTblBloqueadosDTO>> ObtenerTodos()
        {
            var tblBloqueadoss = await _tblBloqueadosRepository.ObtenerTodos();
            var TblBloqueadossDTO = new List<ReadTblBloqueadosDTO>();

            foreach (var tblBloqueados in tblBloqueadoss)
            {
                var tblBloqueadosDTO = new ReadTblBloqueadosDTO
                {
                    lBloqueados_id = tblBloqueados.lBloqueados_id,
                    lPersonas_id = tblBloqueados.lPersonas_id,
                    sBloqueado_fecha_inicio = tblBloqueados.sBloqueado_fecha_inicio,
                    sBloqueado_estado = tblBloqueados.sBloqueado_estado,
                    sBloqueado_motivo = tblBloqueados.sBloqueado_motivo,
                    sBloqueado_fecha_fin = tblBloqueados.sBloqueado_fecha_fin
                };
                TblBloqueadossDTO.Add(tblBloqueadosDTO);
            }

            return TblBloqueadossDTO;
        }
    }
}