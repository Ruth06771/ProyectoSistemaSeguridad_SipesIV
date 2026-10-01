using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblHorario;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblHorarioService : ITblHorarioService
    {
        private readonly ITblHorarioRepository _tblHorarioRepository;
        public TblHorarioService(ITblHorarioRepository tblHorarioRepository)
        {
            _tblHorarioRepository = tblHorarioRepository;
        }
        public async Task Crear(CreateTblHorarioDTO tblHorario)
        {
            TblHorario objTblHorario = new TblHorario
            {
                lArea_id = tblHorario.lArea_id,
                sHorario_fecha_inicio = tblHorario.sHorario_fecha_inicio,
                sHorario_fecha_fin = tblHorario.sHorario_fecha_fin
            };
            await _tblHorarioRepository.Crear(objTblHorario);
        }

        public async Task Actualizar(UpdateTblHorarioDTO tblHorario)
        {
            TblHorario objTblHorario = new TblHorario
            {
                lhorario_id = tblHorario.lhorario_id,
                lArea_id = tblHorario.lArea_id,
                sHorario_fecha_inicio = tblHorario.sHorario_fecha_inicio,
                sHorario_fecha_fin = tblHorario.sHorario_fecha_fin
            };
            await _tblHorarioRepository.Actualizar(objTblHorario);
        }

        public async Task Eliminar(int idHorarios)
        {
            await _tblHorarioRepository.Eliminar(idHorarios);
        }

        public async Task<ReadTblHorarioDTO> ObtenerPorId(int idHorarios)
        {
            var result = await _tblHorarioRepository.ObtenerPorId(idHorarios);
            if (result is null) return null;
            return new ReadTblHorarioDTO
            {
                lhorario_id = result.lhorario_id,
                lArea_id = result.lArea_id,
                sHorario_fecha_inicio = result.sHorario_fecha_inicio,
                sHorario_fecha_fin = result.sHorario_fecha_fin
            };
        }

        public async Task<List<ReadTblHorarioDTO>> ObtenerTodos()
        {
            var tblHorarios = await _tblHorarioRepository.ObtenerTodos();
            var TblHorariosDTO = new List<ReadTblHorarioDTO>();

            foreach (var tblHorario in tblHorarios)
            {
                var tblHorarioDTO = new ReadTblHorarioDTO
                {
                    lhorario_id = tblHorario.lhorario_id,
                    lArea_id = tblHorario.lArea_id,
                    sHorario_fecha_inicio = tblHorario.sHorario_fecha_inicio,
                    sHorario_fecha_fin = tblHorario.sHorario_fecha_fin
                };
                TblHorariosDTO.Add(tblHorarioDTO);
            }

            return TblHorariosDTO;
        }
    }
}
