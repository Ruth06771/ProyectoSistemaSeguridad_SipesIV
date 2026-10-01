using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblAreaService : ITblAreaService
    {
        private readonly ITblAreaRepository _tblAreaRepository;
        public TblAreaService(ITblAreaRepository tblAreaRepository)
        {
            _tblAreaRepository = tblAreaRepository;
        }
        public async Task Crear(CreateTblAreaDTO tblArea)
        {
            TblArea objTblArea = new TblArea
            {
                lPiso_id = tblArea.lPiso_id,
                sArea_nombre = tblArea.sArea_nombre,
                sArea_capacidad_maxima = tblArea.sArea_capacidad_maxima,
                sArea_estado = tblArea.sArea_estado,
                sArea_codigo_aula = tblArea.sArea_codigo_aula
            };
            await _tblAreaRepository.Crear(objTblArea);
        }

        public async Task Actualizar(UpdateTblAreaDTO tblArea)
        {
            TblArea objTblArea = new TblArea
            {
                lArea_id = tblArea.lArea_id,
                lPiso_id = tblArea.lPiso_id,
                sArea_nombre = tblArea.sArea_nombre,
                sArea_capacidad_maxima = tblArea.sArea_capacidad_maxima,
                sArea_estado = tblArea.sArea_estado,
                sArea_codigo_aula = tblArea.sArea_codigo_aula
            };
            await _tblAreaRepository.Actualizar(objTblArea);
        }

        public async Task Eliminar(int idArea)
        {
            await _tblAreaRepository.Eliminar(idArea);
        }

        public async Task<ReadTblAreaDTO> ObtenerPorId(int idArea)
        {
            var result = await _tblAreaRepository.ObtenerPorId(idArea);
            if (result is null) return null;
            return new ReadTblAreaDTO
            {
                lArea_id = result.lArea_id,
                lPiso_id = result.lPiso_id,
                sArea_nombre = result.sArea_nombre,
                sArea_capacidad_maxima = result.sArea_capacidad_maxima,
                sArea_estado = result.sArea_estado,
                sArea_codigo_aula = result.sArea_codigo_aula
            };
        }

        public async Task<List<ReadTblAreaDTO>> ObtenerTodos()
        {
            var tblAreas = await _tblAreaRepository.ObtenerTodos();
            var TblAreasDTO = new List<ReadTblAreaDTO>();

            foreach (var tblArea in tblAreas)
            {
                var tblAreaDTO = new ReadTblAreaDTO
                {
                    lArea_id = tblArea.lArea_id,
                    lPiso_id = tblArea.lPiso_id,
                    sArea_nombre = tblArea.sArea_nombre,
                    sArea_capacidad_maxima = tblArea.sArea_capacidad_maxima,
                    sArea_estado = tblArea.sArea_estado,
                    sArea_codigo_aula = tblArea.sArea_codigo_aula
                };
                TblAreasDTO.Add(tblAreaDTO);
            }

            return TblAreasDTO;
        }
    }
}

