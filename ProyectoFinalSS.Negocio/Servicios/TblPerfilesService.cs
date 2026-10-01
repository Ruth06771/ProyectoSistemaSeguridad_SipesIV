using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblPerfiles;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblPerfilesService : ITblPerfilesService
    {
        private readonly ITblPerfilesRepository _tblPerfilesRepository;
        public TblPerfilesService(ITblPerfilesRepository tblPerfilesRepository)
        {
            _tblPerfilesRepository = tblPerfilesRepository;
        }
        public async Task Crear(CreateTblPerfilesDTO tblPerfiles)
        {
            TblPerfiles objTblPerfiles = new TblPerfiles
            {
                sPerfiles_nm = tblPerfiles.sPerfiles_nm,
                sPerfiles_estado = tblPerfiles.sPerfiles_estado,
                sPerfiles_descripcion = tblPerfiles.sPerfiles_descripcion
            };
            await _tblPerfilesRepository.Crear(objTblPerfiles);
        }

        public async Task Actualizar(UpdateTblPerfilesDTO tblPerfiles)
        {
            TblPerfiles objTblPerfiles = new TblPerfiles
            {
                lPerfiles_id = tblPerfiles.lPerfiles_id,
                sPerfiles_nm = tblPerfiles.sPerfiles_nm,
                sPerfiles_estado = tblPerfiles.sPerfiles_estado,
                sPerfiles_descripcion = tblPerfiles.sPerfiles_descripcion
            };
            await _tblPerfilesRepository.Actualizar(objTblPerfiles);
        }

        public async Task Eliminar(int idPerfiles)
        {
            await _tblPerfilesRepository.Eliminar(idPerfiles);
        }

        public async Task<ReadTblPerfilesDTO> ObtenerPorId(int idPerfiles)
        {
            var result = await _tblPerfilesRepository.ObtenerPorId(idPerfiles);
            if (result is null) return null;
            return new ReadTblPerfilesDTO
            {
                lPerfiles_id = result.lPerfiles_id,
                sPerfiles_nm = result.sPerfiles_nm,
                sPerfiles_estado = result.sPerfiles_estado,
                sPerfiles_descripcion = result.sPerfiles_descripcion
            };
        }

        public async Task<List<ReadTblPerfilesDTO>> ObtenerTodos()
        {
            var tblPerfiless = await _tblPerfilesRepository.ObtenerTodos();
            var TblPerfilessDTO = new List<ReadTblPerfilesDTO>();

            foreach (var tblPerfiles in tblPerfiless)
            {
                var tblPerfilesDTO = new ReadTblPerfilesDTO
                {
                    lPerfiles_id = tblPerfiles.lPerfiles_id,
                    sPerfiles_nm = tblPerfiles.sPerfiles_nm,
                    sPerfiles_estado = tblPerfiles.sPerfiles_estado,
                    sPerfiles_descripcion = tblPerfiles.sPerfiles_descripcion
                };
                TblPerfilessDTO.Add(tblPerfilesDTO);
            }

            return TblPerfilessDTO;
        }
    }
}