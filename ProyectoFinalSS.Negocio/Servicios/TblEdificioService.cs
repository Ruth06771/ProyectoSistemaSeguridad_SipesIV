using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblEdificio;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblEdificioService : ITblEdificiosService
    {
        private readonly ITblEdificiosRepository _tblEdificioRepository;
        public TblEdificioService(ITblEdificiosRepository tblEdificioRepository)
        {
            _tblEdificioRepository = tblEdificioRepository;
        }
        public async Task Crear(CreateTblEdificioDTO tblEdificio)
        {
            TblEdificios objTblEdificio = new TblEdificios
            {
                sEdificio_nombre = tblEdificio.sEdificio_nombre,
                sEdificio_estado = tblEdificio.sEdificio_estado,
                sEdificio_descripcion = tblEdificio.sEdificio_descripcion
            };
            await _tblEdificioRepository.Crear(objTblEdificio);
        }

        public async Task Actualizar(UpdateTblEdificioDTO tblEdificio)
        {
            TblEdificios objTblEdificio = new TblEdificios
            {
                lEdificio_id = tblEdificio.lEdificio_id,
                sEdificio_nombre = tblEdificio.sEdificio_nombre,
                sEdificio_estado = tblEdificio.sEdificio_estado,
                sEdificio_descripcion = tblEdificio.sEdificio_descripcion
            };
            await _tblEdificioRepository.Actualizar(objTblEdificio);
        }

        public async Task Eliminar(int idEdificios)
        {
            await _tblEdificioRepository.Eliminar(idEdificios);
        }

        public async Task<ReadTblEdificioDTO> ObtenerPorId(int idEdificios)
        {
            var result = await _tblEdificioRepository.ObtenerPorId(idEdificios);
            if (result is null) return null;
            return new ReadTblEdificioDTO
            {
                lEdificio_id = result.lEdificio_id,
                sEdificio_nombre = result.sEdificio_nombre,
                sEdificio_estado = result.sEdificio_estado,
                sEdificio_descripcion = result.sEdificio_descripcion
            };
        }

        public async Task<List<ReadTblEdificioDTO>> ObtenerTodos()
        {
            var tblEdificios = await _tblEdificioRepository.ObtenerTodos();
            var TblEdificiosDTO = new List<ReadTblEdificioDTO>();

            foreach (var tblEdificio in tblEdificios)
            {
                var tblEdificioDTO = new ReadTblEdificioDTO
                {
                    lEdificio_id = tblEdificio.lEdificio_id,
                    sEdificio_nombre = tblEdificio.sEdificio_nombre,
                    sEdificio_estado = tblEdificio.sEdificio_estado,
                    sEdificio_descripcion = tblEdificio.sEdificio_descripcion
                };
                TblEdificiosDTO.Add(tblEdificioDTO);
            }

            return TblEdificiosDTO;
        }
    }
}
