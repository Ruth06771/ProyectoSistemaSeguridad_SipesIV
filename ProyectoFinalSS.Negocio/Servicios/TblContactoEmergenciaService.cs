using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblContactoEmergencia;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblContactoEmergenciaService : ITblContactoEmergenciaService
    {
        private readonly ITblContactoEmergenciaRepository _tblContactoEmergenciaRepository;
        public TblContactoEmergenciaService(ITblContactoEmergenciaRepository tblContactoEmergenciaRepository)
        {
            _tblContactoEmergenciaRepository = tblContactoEmergenciaRepository;
        }
        public async Task Crear(CreateTblContactoEmergenciaDTO tblContactoEmergencia)
        {
            TblContactoEmergencia objTblContactoEmergencia = new TblContactoEmergencia
            {
                lPersonas_id = tblContactoEmergencia.lPersonas_id,
                sContacto_emerg_nm = tblContactoEmergencia.sContacto_emerg_nm,
                sContacto_emerg_telefono = tblContactoEmergencia.sContacto_emerg_telefono,
                sContacto_emerg_relacion = tblContactoEmergencia.sContacto_emerg_relacion,
                sContacto_emerg_direccion = tblContactoEmergencia.sContacto_emerg_direccion
            };
            await _tblContactoEmergenciaRepository.Crear(objTblContactoEmergencia);
        }

        public async Task Actualizar(UpdateTblContactoEmergenciaDTO tblContactoEmergencia)
        {
            TblContactoEmergencia objTblContactoEmergencia = new TblContactoEmergencia
            {
                lContacto_emerg_id = tblContactoEmergencia.lContacto_emerg_id,
                lPersonas_id = tblContactoEmergencia.lPersonas_id,
                sContacto_emerg_nm = tblContactoEmergencia.sContacto_emerg_nm,
                sContacto_emerg_telefono = tblContactoEmergencia.sContacto_emerg_telefono,
                sContacto_emerg_relacion = tblContactoEmergencia.sContacto_emerg_relacion,
                sContacto_emerg_direccion = tblContactoEmergencia.sContacto_emerg_direccion
            };
            await _tblContactoEmergenciaRepository.Actualizar(objTblContactoEmergencia);
        }

        public async Task Eliminar(int idContactoEmergencia)
        {
            await _tblContactoEmergenciaRepository.Eliminar(idContactoEmergencia);
        }

        public async Task<ReadTblContactoEmergenciaDTO> ObtenerPorId(int idContactoEmergencia)
        {
            var result = await _tblContactoEmergenciaRepository.ObtenerPorId(idContactoEmergencia);
            if (result is null) return null;
            return new ReadTblContactoEmergenciaDTO
            {
                lContacto_emerg_id = result.lContacto_emerg_id,
                lPersonas_id = result.lPersonas_id,
                sContacto_emerg_nm = result.sContacto_emerg_nm,
                sContacto_emerg_telefono = result.sContacto_emerg_telefono,
                sContacto_emerg_relacion = result.sContacto_emerg_relacion,
                sContacto_emerg_direccion = result.sContacto_emerg_direccion
            };
        }

        public async Task<List<ReadTblContactoEmergenciaDTO>> ObtenerTodos()
        {
            var tblContactoEmergencias = await _tblContactoEmergenciaRepository.ObtenerTodos();
            var TblContactoEmergenciasDTO = new List<ReadTblContactoEmergenciaDTO>();

            foreach (var tblContactoEmergencia in tblContactoEmergencias)
            {
                var tblContactoEmergenciaDTO = new ReadTblContactoEmergenciaDTO
                {
                    lContacto_emerg_id = tblContactoEmergencia.lContacto_emerg_id,
                    lPersonas_id = tblContactoEmergencia.lPersonas_id,
                    sContacto_emerg_nm = tblContactoEmergencia.sContacto_emerg_nm,
                    sContacto_emerg_telefono = tblContactoEmergencia.sContacto_emerg_telefono,
                    sContacto_emerg_relacion = tblContactoEmergencia.sContacto_emerg_relacion,
                    sContacto_emerg_direccion = tblContactoEmergencia.sContacto_emerg_direccion
                };
                TblContactoEmergenciasDTO.Add(tblContactoEmergenciaDTO);
            }

            return TblContactoEmergenciasDTO;
        }
    }
}
