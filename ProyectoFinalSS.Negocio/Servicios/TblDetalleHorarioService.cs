using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblDetalleHorario;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblDetalleHorarioService : ITblDetalleHorarioService
    {
        private readonly ITblDetalleHorarioRepository _tblDetalleHorarioRepository;
        public TblDetalleHorarioService(ITblDetalleHorarioRepository tblDetalleHorarioRepository)
        {
            _tblDetalleHorarioRepository = tblDetalleHorarioRepository;
        }
        public async Task Crear(CreateTblDetalleHorarioDTO tblDetalleHorario)
        {
            TblDetalleHorario objTblDetalleHorario = new TblDetalleHorario
            {
                lhorario_id = tblDetalleHorario.lhorario_id,
                lGrupo_id = tblDetalleHorario.lGrupo_id,
                sDetalleHorario_dia = tblDetalleHorario.sDetalleHorario_dia,
                sDetalleHorario_hora_inicio = tblDetalleHorario.sDetalleHorario_hora_inicio,
                sDetalleHorario_hora_fin = tblDetalleHorario.sDetalleHorario_hora_fin
            };
            await _tblDetalleHorarioRepository.Crear(objTblDetalleHorario);
        }

        public async Task Actualizar(UpdateTblDetalleHorarioDTO tblDetalleHorario)
        {
            TblDetalleHorario objTblDetalleHorario = new TblDetalleHorario
            {
                lDetalleHorario_id = tblDetalleHorario.lDetalleHorario_id,
                lhorario_id = tblDetalleHorario.lhorario_id,
                lGrupo_id = tblDetalleHorario.lGrupo_id,
                sDetalleHorario_dia = tblDetalleHorario.sDetalleHorario_dia,
                sDetalleHorario_hora_inicio = tblDetalleHorario.sDetalleHorario_hora_inicio,
                sDetalleHorario_hora_fin = tblDetalleHorario.sDetalleHorario_hora_fin
            };
            await _tblDetalleHorarioRepository.Actualizar(objTblDetalleHorario);
        }

        public async Task Eliminar(int idDetalleHorario)
        {
            await _tblDetalleHorarioRepository.Eliminar(idDetalleHorario);
        }

        public async Task<ReadTblDetalleHorarioDTO> ObtenerPorId(int idDetalleHorario)
        {
            var result = await _tblDetalleHorarioRepository.ObtenerPorId(idDetalleHorario);
            if (result is null) return null;
            return new ReadTblDetalleHorarioDTO
            {
                lDetalleHorario_id = result.lDetalleHorario_id,
                lhorario_id = result.lhorario_id,
                lGrupo_id = result.lGrupo_id,
                sDetalleHorario_dia = result.sDetalleHorario_dia,
                sDetalleHorario_hora_inicio = result.sDetalleHorario_hora_inicio,
                sDetalleHorario_hora_fin = result.sDetalleHorario_hora_fin
            };
        }

        public async Task<List<ReadTblDetalleHorarioDTO>> ObtenerTodos()
        {
            var tblDetalleHorarios = await _tblDetalleHorarioRepository.ObtenerTodos();
            var TblDetalleHorariosDTO = new List<ReadTblDetalleHorarioDTO>();

            foreach (var tblDetalleHorario in tblDetalleHorarios)
            {
                var tblDetalleHorarioDTO = new ReadTblDetalleHorarioDTO
                {
                    lDetalleHorario_id = tblDetalleHorario.lDetalleHorario_id,
                    lhorario_id = tblDetalleHorario.lhorario_id,
                    lGrupo_id = tblDetalleHorario.lGrupo_id,
                    sDetalleHorario_dia = tblDetalleHorario.sDetalleHorario_dia,
                    sDetalleHorario_hora_inicio = tblDetalleHorario.sDetalleHorario_hora_inicio,
                    sDetalleHorario_hora_fin = tblDetalleHorario.sDetalleHorario_hora_fin
                };
                TblDetalleHorariosDTO.Add(tblDetalleHorarioDTO);
            }

            return TblDetalleHorariosDTO;
        }
    }
}