using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblPasesEspeciales;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblPasesEspecialesService : ITblPasesEspecialesService
    {
        private readonly ITblPasesEspecialesRepository _tblPasesEspecialesRepository;
        public TblPasesEspecialesService(ITblPasesEspecialesRepository tblPasesEspecialesRepository)
        {
            _tblPasesEspecialesRepository = tblPasesEspecialesRepository;
        }
        public async Task Crear(CreateTblPasesEspecialesDTO tblPasesEspeciales)
        {
            TblPasesEspeciales objTblPasesEspeciales = new TblPasesEspeciales
            {
                lPersonas_id = tblPasesEspeciales.lPersonas_id,
                lLector_id = tblPasesEspeciales.lLector_id,
                lPasesEspeciales_motivo = tblPasesEspeciales.lPasesEspeciales_motivo,
                lPasesEspeciales_fecha_inicio = tblPasesEspeciales.lPasesEspeciales_fecha_inicio,
                lPasesEspeciales_fecha_fin = tblPasesEspeciales.lPasesEspeciales_fecha_fin,
                lPasesEspeciales_estado = tblPasesEspeciales.lPasesEspeciales_estado
            };
            await _tblPasesEspecialesRepository.Crear(objTblPasesEspeciales);
        }

        public async Task Actualizar(UpdateTblPasesEspecialesDTO tblPasesEspeciales)
        {
            TblPasesEspeciales objTblPasesEspeciales = new TblPasesEspeciales
            {
                lPasesEspeciales_id = tblPasesEspeciales.lPasesEspeciales_id,
                lPersonas_id = tblPasesEspeciales.lPersonas_id,
                lLector_id = tblPasesEspeciales.lLector_id,
                lPasesEspeciales_motivo = tblPasesEspeciales.lPasesEspeciales_motivo,
                lPasesEspeciales_fecha_inicio = tblPasesEspeciales.lPasesEspeciales_fecha_inicio,
                lPasesEspeciales_fecha_fin = tblPasesEspeciales.lPasesEspeciales_fecha_fin,
                lPasesEspeciales_estado = tblPasesEspeciales.lPasesEspeciales_estado
            };
            await _tblPasesEspecialesRepository.Actualizar(objTblPasesEspeciales);
        }

        public async Task Eliminar(int idPasesEspeciales)
        {
            await _tblPasesEspecialesRepository.Eliminar(idPasesEspeciales);
        }

        public async Task<ReadTblPasesEspecialesDTO> ObtenerPorId(int idPasesEspeciales)
        {
            var result = await _tblPasesEspecialesRepository.ObtenerPorId(idPasesEspeciales);
            if (result is null) return null;
            return new ReadTblPasesEspecialesDTO
            {
                lPasesEspeciales_id = result.lPasesEspeciales_id,
                lPersonas_id = result.lPersonas_id,
                lLector_id = result.lLector_id,
                lPasesEspeciales_motivo = result.lPasesEspeciales_motivo,
                lPasesEspeciales_fecha_inicio = result.lPasesEspeciales_fecha_inicio,
                lPasesEspeciales_fecha_fin = result.lPasesEspeciales_fecha_fin,
                lPasesEspeciales_estado = result.lPasesEspeciales_estado
            };
        }

        public async Task<List<ReadTblPasesEspecialesDTO>> ObtenerTodos()
        {
            var tblPasesEspecialess = await _tblPasesEspecialesRepository.ObtenerTodos();
            var TblPasesEspecialessDTO = new List<ReadTblPasesEspecialesDTO>();

            foreach (var tblPasesEspeciales in tblPasesEspecialess)
            {
                var tblPasesEspecialesDTO = new ReadTblPasesEspecialesDTO
                {
                    lPasesEspeciales_id = tblPasesEspeciales.lPasesEspeciales_id,
                    lPersonas_id = tblPasesEspeciales.lPersonas_id,
                    lLector_id = tblPasesEspeciales.lLector_id,
                    lPasesEspeciales_motivo = tblPasesEspeciales.lPasesEspeciales_motivo,
                    lPasesEspeciales_fecha_inicio = tblPasesEspeciales.lPasesEspeciales_fecha_inicio,
                    lPasesEspeciales_fecha_fin = tblPasesEspeciales.lPasesEspeciales_fecha_fin,
                    lPasesEspeciales_estado = tblPasesEspeciales.lPasesEspeciales_estado
                };
                TblPasesEspecialessDTO.Add(tblPasesEspecialesDTO);
            }

            return TblPasesEspecialessDTO;
        }
    }
}
