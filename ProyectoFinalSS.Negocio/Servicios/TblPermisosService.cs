using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblPermisos;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblPermisosService : ITblPermisosService
    {
        private readonly ITblPermisosRepository _tblPermisosRepository;
        public TblPermisosService(ITblPermisosRepository tblPermisosRepository)
        {
            _tblPermisosRepository = tblPermisosRepository;
        }
        public async Task Crear(CreateTblPermisosDTO tblPermisos)
        {
            TblPermisos objTblPermisos = new TblPermisos
            {
                lPerfiles_id = tblPermisos.lPerfiles_id,
                lmodulo_id = tblPermisos.lmodulo_id,
                sPermisos_puede_ver = tblPermisos.sPermisos_puede_ver,
                sPermisos_puede_crear = tblPermisos.sPermisos_puede_crear,
                sPermisos_puede_editar = tblPermisos.sPermisos_puede_editar,
                sPermisos_puede_eliminar = tblPermisos.sPermisos_puede_eliminar
            };
            await _tblPermisosRepository.Crear(objTblPermisos);
        }

        public async Task Actualizar(UpdateTblPermisosDTO tblPermisos)
        {
            TblPermisos objTblPermisos = new TblPermisos
            {
                lPermisos_id = tblPermisos.lPermisos_id,
                lPerfiles_id = tblPermisos.lPerfiles_id,
                lmodulo_id = tblPermisos.lmodulo_id,
                sPermisos_puede_ver = tblPermisos.sPermisos_puede_ver,
                sPermisos_puede_crear = tblPermisos.sPermisos_puede_crear,
                sPermisos_puede_editar = tblPermisos.sPermisos_puede_editar,
                sPermisos_puede_eliminar = tblPermisos.sPermisos_puede_eliminar
            };
            await _tblPermisosRepository.Actualizar(objTblPermisos);
        }

        public async Task Eliminar(int idPermisos)
        {
            await _tblPermisosRepository.Eliminar(idPermisos);
        }

        public async Task<ReadTblPermisosDTO> ObtenerPorId(int idPermisos)
        {
            var result = await _tblPermisosRepository.ObtenerPorId(idPermisos);
            if (result is null) return null;
            return new ReadTblPermisosDTO
            {
                lPermisos_id = result.lPermisos_id,
                lPerfiles_id = result.lPerfiles_id,
                lmodulo_id = result.lmodulo_id,
                sPermisos_puede_ver = result.sPermisos_puede_ver,
                sPermisos_puede_crear = result.sPermisos_puede_crear,
                sPermisos_puede_editar = result.sPermisos_puede_editar,
                sPermisos_puede_eliminar = result.sPermisos_puede_eliminar
            };
        }

        public async Task<List<ReadTblPermisosDTO>> ObtenerTodos()
        {
            var tblPermisoss = await _tblPermisosRepository.ObtenerTodos();
            var TblPermisossDTO = new List<ReadTblPermisosDTO>();

            foreach (var tblPermisos in tblPermisoss)
            {
                var tblPermisosDTO = new ReadTblPermisosDTO
                {
                    lPermisos_id = tblPermisos.lPermisos_id,
                    lPerfiles_id = tblPermisos.lPerfiles_id,
                    lmodulo_id = tblPermisos.lmodulo_id,
                    sPermisos_puede_ver = tblPermisos.sPermisos_puede_ver,
                    sPermisos_puede_crear = tblPermisos.sPermisos_puede_crear,
                    sPermisos_puede_editar = tblPermisos.sPermisos_puede_editar,
                    sPermisos_puede_eliminar = tblPermisos.sPermisos_puede_eliminar
                };
                TblPermisossDTO.Add(tblPermisosDTO);
            }

            return TblPermisossDTO;
        }
    }
}
