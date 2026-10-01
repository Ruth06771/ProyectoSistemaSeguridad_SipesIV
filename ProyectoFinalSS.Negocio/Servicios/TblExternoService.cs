using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblExterno;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblExternoService : ITblExternoService
    {
        private readonly ITblExternoRepository _tblExternoRepository;
        public TblExternoService(ITblExternoRepository tblExternoRepository)
        {
            _tblExternoRepository = tblExternoRepository;
        }
        public async Task Crear(CreateTblExternoDTO tblExterno)
        {
            TblExterno objTblExterno = new TblExterno
            {
                lGrupo_id = tblExterno.lGrupo_id,
                sExterno_nm = tblExterno.sExterno_nm
            };
            await _tblExternoRepository.Crear(objTblExterno);
        }

        public async Task Actualizar(UpdateTblExternoDTO tblExterno)
        {
            TblExterno objTblExterno = new TblExterno
            {
                lGrupo_id = tblExterno.lGrupo_id,
                sExterno_nm = tblExterno.sExterno_nm
            };
            await _tblExternoRepository.Actualizar(objTblExterno);
        }

        public async Task Eliminar(int idExterno)
        {
            await _tblExternoRepository.Eliminar(idExterno);
        }

        public async Task<ReadTblExternoDTO> ObtenerPorId(int idExterno)
        {
            var result = await _tblExternoRepository.ObtenerPorId(idExterno);
            if (result is null) return null;
            return new ReadTblExternoDTO
            {
                lGrupo_id = result.lGrupo_id,
                sExterno_nm = result.sExterno_nm
            };
        }

        public async Task<List<ReadTblExternoDTO>> ObtenerTodos()
        {
            var tblExternos = await _tblExternoRepository.ObtenerTodos();
            var TblExternosDTO = new List<ReadTblExternoDTO>();

            foreach (var tblExterno in tblExternos)
            {
                var tblExternoDTO = new ReadTblExternoDTO
                {
                    lGrupo_id = tblExterno.lGrupo_id,
                    sExterno_nm = tblExterno.sExterno_nm
                };
                TblExternosDTO.Add(tblExternoDTO);
            }

            return TblExternosDTO;
        }
    }
}
