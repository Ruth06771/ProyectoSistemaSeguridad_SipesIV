using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblGrupo;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblGrupoService : ITblGrupoService
    {
        private readonly ITblGrupoRepository _tblGrupoRepository;
        public TblGrupoService(ITblGrupoRepository tblGrupoRepository)
        {
            _tblGrupoRepository = tblGrupoRepository;
        }
        public async Task Crear(CreateTblGrupoDTO tblGrupo)
        {
            TblGrupo objTblGrupo = new TblGrupo
            {
                sGrupo_descripcion = tblGrupo.sGrupo_descripcion,
                sGrupo_estado = tblGrupo.sGrupo_estado,
                sGrupo_tipo_grupo = tblGrupo.sGrupo_tipo_grupo
            };
            await _tblGrupoRepository.Crear(objTblGrupo);
        }

        public async Task Actualizar(UpdateTblGrupoDTO tblGrupo)
        {
            TblGrupo objTblGrupo = new TblGrupo
            {
                lGrupo_id = tblGrupo.lGrupo_id,
                sGrupo_descripcion = tblGrupo.sGrupo_descripcion,
                sGrupo_estado = tblGrupo.sGrupo_estado,
                sGrupo_tipo_grupo = tblGrupo.sGrupo_tipo_grupo
            };
            await _tblGrupoRepository.Actualizar(objTblGrupo);
        }

        public async Task Eliminar(int idGrupo)
        {
            await _tblGrupoRepository.Eliminar(idGrupo);
        }

        public async Task<ReadTblGrupoDTO> ObtenerPorId(int idGrupo)
        {
            var result = await _tblGrupoRepository.ObtenerPorId(idGrupo);
            if (result is null) return null;
            return new ReadTblGrupoDTO
            {
                lGrupo_id = result.lGrupo_id,
                sGrupo_descripcion = result.sGrupo_descripcion,
                sGrupo_estado = result.sGrupo_estado,
                sGrupo_tipo_grupo = result.sGrupo_tipo_grupo
            };
        }

        public async Task<List<ReadTblGrupoDTO>> ObtenerTodos()
        {
            var tblGrupos = await _tblGrupoRepository.ObtenerTodos();
            var TblGruposDTO = new List<ReadTblGrupoDTO>();

            foreach (var tblGrupo in tblGrupos)
            {
                var tblGrupoDTO = new ReadTblGrupoDTO
                {
                    lGrupo_id = tblGrupo.lGrupo_id,
                    sGrupo_descripcion = tblGrupo.sGrupo_descripcion,
                    sGrupo_estado = tblGrupo.sGrupo_estado,
                    sGrupo_tipo_grupo = tblGrupo.sGrupo_tipo_grupo
                };
                TblGruposDTO.Add(tblGrupoDTO);
            }

            return TblGruposDTO;
        }
    }
}

