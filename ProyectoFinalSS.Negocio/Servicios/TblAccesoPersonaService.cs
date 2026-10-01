using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblAccesoPersona;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblAccesoPersonaService : ITblAccesoPersonaService
    {
        private readonly ITblAccesoPersonaRepository _tblAccesoPersonaRepository;
        public TblAccesoPersonaService(ITblAccesoPersonaRepository tblAccesoPersonaRepository)
        {
            _tblAccesoPersonaRepository = tblAccesoPersonaRepository;
        }
        public async Task Crear(CreateTblAccesoPersonaDTO tblAccesoPersona)
        {
            TblAccesoPersona objTblAccesoPersona = new TblAccesoPersona
            {
                lPersonas_id = tblAccesoPersona.lPersonas_id
            };
            await _tblAccesoPersonaRepository.Crear(objTblAccesoPersona);
        }

        public async Task Actualizar(UpdateTblAccesoPersonaDTO tblAccesoPersona)
        {
            TblAccesoPersona objTblAccesoPersona = new TblAccesoPersona
            {
                lTRegis_id = tblAccesoPersona.lTRegis_id,
                lPersonas_id = tblAccesoPersona.lPersonas_id
            };
            await _tblAccesoPersonaRepository.Actualizar(objTblAccesoPersona);
        }

        public async Task Eliminar(int idAccesoPersona)
        {
            await _tblAccesoPersonaRepository.Eliminar(idAccesoPersona);
        }

        public async Task<ReadTblAccesoPersonaDTO> ObtenerPorId(int idAccesoPersona)
        {
            var result = await _tblAccesoPersonaRepository.ObtenerPorId(idAccesoPersona);
            if (result is null) return null;
            return new ReadTblAccesoPersonaDTO
            {
                lTRegis_id = result.lTRegis_id,
                lPersonas_id = result.lPersonas_id
            };
        }

        public async Task<List<ReadTblAccesoPersonaDTO>> ObtenerTodos()
        {
            var tblAccesoPersonas = await _tblAccesoPersonaRepository.ObtenerTodos();
            var TblAccesoPersonasDTO = new List<ReadTblAccesoPersonaDTO>();

            foreach (var tblAccesoPersona in tblAccesoPersonas)
            {
                var tblAccesoPersonaDTO = new ReadTblAccesoPersonaDTO
                {
                    lTRegis_id = tblAccesoPersona.lTRegis_id,
                    lPersonas_id = tblAccesoPersona.lPersonas_id
                };
                TblAccesoPersonasDTO.Add(tblAccesoPersonaDTO);
            }

            return TblAccesoPersonasDTO;
        }
    }
}

