using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblPisos;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblPisosService : ITblPisosService
    {
        private readonly ITblPisosRepository _tblPisosRepository;
        public TblPisosService(ITblPisosRepository tblPisosRepository)
        {
            _tblPisosRepository = tblPisosRepository;
        }
        public async Task Crear(CreateTblPisosDTO tblPisos)
        {
            TblPisos objTblPisos = new TblPisos
            {
                lEdificios_id = tblPisos.lEdificios_id,
                sPiso_nombre = tblPisos.sPiso_nombre,
                sPiso_codigo_corto = tblPisos.sPiso_codigo_corto
            };
            await _tblPisosRepository.Crear(objTblPisos);
        }

        public async Task Actualizar(UpdateTblPisosDTO tblPisos)
        {
            TblPisos objTblPisos = new TblPisos
            {
                lPisos_id = tblPisos.lPisos_id,
                lEdificios_id = tblPisos.lEdificios_id,
                sPiso_nombre = tblPisos.sPiso_nombre,
                sPiso_codigo_corto = tblPisos.sPiso_codigo_corto
            };
            await _tblPisosRepository.Actualizar(objTblPisos);
        }

        public async Task Eliminar(int idPisos)
        {
            await _tblPisosRepository.Eliminar(idPisos);
        }

        public async Task<ReadTblPisosDTO> ObtenerPorId(int idPisos)
        {
            var result = await _tblPisosRepository.ObtenerPorId(idPisos);
            if (result is null) return null;
            return new ReadTblPisosDTO
            {
                lPisos_id = result.lPisos_id,
                lEdificios_id = result.lEdificios_id,
                sPiso_nombre = result.sPiso_nombre,
                sPiso_codigo_corto = result.sPiso_codigo_corto
            };
        }

        public async Task<List<ReadTblPisosDTO>> ObtenerTodos()
        {
            var tblPisoss = await _tblPisosRepository.ObtenerTodos();
            var TblPisossDTO = new List<ReadTblPisosDTO>();

            foreach (var tblPisos in tblPisoss)
            {
                var tblPisosDTO = new ReadTblPisosDTO
                {
                    lPisos_id = tblPisos.lPisos_id,
                    lEdificios_id = tblPisos.lEdificios_id,
                    sPiso_nombre = tblPisos.sPiso_nombre,
                    sPiso_codigo_corto = tblPisos.sPiso_codigo_corto
                };
                TblPisossDTO.Add(tblPisosDTO);
            }

            return TblPisossDTO;
        }
    }
}
