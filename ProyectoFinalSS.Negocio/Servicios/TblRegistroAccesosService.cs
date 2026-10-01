using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblRegistroAccesos;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblRegistroAccesosService : ITblRegistroAccesosService
    {
        private readonly ITblRegistroAccesosRepository _tblRegistroAccesosRepository;
        public TblRegistroAccesosService(ITblRegistroAccesosRepository tblRegistroAccesosRepository)
        {
            _tblRegistroAccesosRepository = tblRegistroAccesosRepository;
        }
        public async Task Crear(CreateTblRegistroAccesosDTO tblRegistroAccesos)
        {
            TblRegistroAccesos objTblRegistroAccesos = new TblRegistroAccesos
            {
                lPersonas_id = tblRegistroAccesos.lPersonas_id,
                llector_id = tblRegistroAccesos.llector_id,
                sRegistro_Autorizado = tblRegistroAccesos.sRegistro_Autorizado,
                sRegistro_motivo_denegacion = tblRegistroAccesos.sRegistro_motivo_denegacion,
                sRegistro_fecha_hora = tblRegistroAccesos.sRegistro_fecha_hora
            };
            await _tblRegistroAccesosRepository.Crear(objTblRegistroAccesos);
        }

        public async Task Actualizar(UpdateTblRegistroAccesosDTO tblRegistroAccesos)
        {
            TblRegistroAccesos objTblRegistroAccesos = new TblRegistroAccesos
            {
                lRegistro_Accesos_id = tblRegistroAccesos.lRegistro_Accesos_id,
                lPersonas_id = tblRegistroAccesos.lPersonas_id,
                llector_id = tblRegistroAccesos.llector_id,
                sRegistro_Autorizado = tblRegistroAccesos.sRegistro_Autorizado,
                sRegistro_motivo_denegacion = tblRegistroAccesos.sRegistro_motivo_denegacion,
                sRegistro_fecha_hora = tblRegistroAccesos.sRegistro_fecha_hora
            };
            await _tblRegistroAccesosRepository.Actualizar(objTblRegistroAccesos);
        }

        public async Task Eliminar(int idRegistroAccesos)
        {
            await _tblRegistroAccesosRepository.Eliminar(idRegistroAccesos);
        }

        public async Task<ReadTblRegistroAccesosDTO> ObtenerPorId(int idRegistroAccesos)
        {
            var result = await _tblRegistroAccesosRepository.ObtenerPorId(idRegistroAccesos);
            if (result is null) return null;
            return new ReadTblRegistroAccesosDTO
            {
                lRegistro_Accesos_id = result.lRegistro_Accesos_id,
                lPersonas_id = result.lPersonas_id,
                llector_id = result.llector_id,
                sRegistro_Autorizado = result.sRegistro_Autorizado,
                sRegistro_motivo_denegacion = result.sRegistro_motivo_denegacion,
                sRegistro_fecha_hora = result.sRegistro_fecha_hora
            };
        }

        public async Task<List<ReadTblRegistroAccesosDTO>> ObtenerTodos()
        {
            var tblRegistroAccesoss = await _tblRegistroAccesosRepository.ObtenerTodos();
            var TblRegistroAccesossDTO = new List<ReadTblRegistroAccesosDTO>();

            foreach (var tblRegistroAccesos in tblRegistroAccesoss)
            {
                var tblRegistroAccesosDTO = new ReadTblRegistroAccesosDTO
                {
                    lRegistro_Accesos_id = tblRegistroAccesos.lRegistro_Accesos_id,
                    lPersonas_id = tblRegistroAccesos.lPersonas_id,
                    llector_id = tblRegistroAccesos.llector_id,
                    sRegistro_Autorizado = tblRegistroAccesos.sRegistro_Autorizado,
                    sRegistro_motivo_denegacion = tblRegistroAccesos.sRegistro_motivo_denegacion,
                    sRegistro_fecha_hora = tblRegistroAccesos.sRegistro_fecha_hora
                };
                TblRegistroAccesossDTO.Add(tblRegistroAccesosDTO);
            }

            return TblRegistroAccesossDTO;
        }
    }
}
