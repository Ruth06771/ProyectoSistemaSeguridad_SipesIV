using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblAcademicoService : ITblAcademicoService
    {
        private readonly ITblAcademicoRepository _tblAcademicoRepository;
        public TblAcademicoService(ITblAcademicoRepository tblAcademicoRepository)
        {
            _tblAcademicoRepository = tblAcademicoRepository;
        }
        public async Task Crear(CreateTblAcademicoDTO tblAcademico)
        {
            TblAcademico objTblAcademico = new TblAcademico
            {
                lGrupo_id = tblAcademico.lGrupo_id,
                lMateria_id = tblAcademico.lMateria_id,
                sAcademico_nombre_grupo = tblAcademico.sAcademico_nombre_grupo
            };
            await _tblAcademicoRepository.Crear(objTblAcademico);
        }

        public async Task Actualizar(UpdateTblAcademicoDTO tblAcademico)
        {
            TblAcademico objTblAcademico = new TblAcademico
            {
                lGrupo_id = tblAcademico.lGrupo_id,
                lMateria_id = tblAcademico.lMateria_id,
                sAcademico_nombre_grupo = tblAcademico.sAcademico_nombre_grupo
            };
            await _tblAcademicoRepository.Actualizar(objTblAcademico);
        }

        public async Task Eliminar(int idAcademico)
        {
            await _tblAcademicoRepository.Eliminar(idAcademico);
        }

        public async Task<ReadTblAcademicoDTO> ObtenerPorId(int idAcademico)
        {
            var result = await _tblAcademicoRepository.ObtenerPorId(idAcademico);
            if (result is null) return null;
            return new ReadTblAcademicoDTO
            {
                lGrupo_id = result.lGrupo_id,
                lMateria_id = result.lMateria_id,
                sAcademico_nombre_grupo = result.sAcademico_nombre_grupo
            };
        }

        public async Task<List<ReadTblAcademicoDTO>> ObtenerTodos()
        {
            var tblAcademicos = await _tblAcademicoRepository.ObtenerTodos();
            var TblAcademicosDTO = new List<ReadTblAcademicoDTO>();

            foreach (var tblAcademico in tblAcademicos)
            {
                var tblAcademicoDTO = new ReadTblAcademicoDTO
                {
                    lGrupo_id = tblAcademico.lGrupo_id,
                    lMateria_id = tblAcademico.lMateria_id,
                    sAcademico_nombre_grupo = tblAcademico.sAcademico_nombre_grupo
                };
                TblAcademicosDTO.Add(tblAcademicoDTO);
            }

            return TblAcademicosDTO;
        }
    }
}
