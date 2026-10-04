using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblMaterias;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblMateriasService : ITblMateriasService
    {
        private readonly ITblMateriasRepository _tblMateriasRepository;
        public TblMateriasService(ITblMateriasRepository tblMateriasRepository)
        {
            _tblMateriasRepository = tblMateriasRepository;
        }
        public async Task Crear(CreateTblMateriasDTO tblMaterias)
        {
            TblMaterias objTblMaterias = new TblMaterias
            {
                sMateria_codigo = tblMaterias.sMateria_codigo,
                sMateria_nombre = tblMaterias.sMateria_nombre,
                sMateria_estado = tblMaterias.sMateria_estado
            };
            await _tblMateriasRepository.Crear(objTblMaterias);
        }

        public async Task Actualizar(UpdateTblMateriasDTO tblMaterias)
        {
            TblMaterias objTblMaterias = new TblMaterias
            {
                lMateria_id = tblMaterias.lMateria_id,
                sMateria_codigo = tblMaterias.sMateria_codigo,
                sMateria_nombre = tblMaterias.sMateria_nombre,
                sMateria_estado = tblMaterias.sMateria_estado
            };
            await _tblMateriasRepository.Actualizar(objTblMaterias);
        }

        public async Task Eliminar(int idMaterias)
        {
            await _tblMateriasRepository.Eliminar(idMaterias);
        }

        public async Task<ReadTblMateriasDTO> ObtenerPorId(int idMaterias)
        {
            var result = await _tblMateriasRepository.ObtenerPorId(idMaterias);
            if (result is null) return null;
            return new ReadTblMateriasDTO
            {
                lMateria_id = result.lMateria_id,
                sMateria_codigo = result.sMateria_codigo,
                sMateria_nombre = result.sMateria_nombre,
                sMateria_estado = result.sMateria_estado
            };
        }

        public async Task<List<ReadTblMateriasDTO>> ObtenerTodos()
        {
            var tblMateriass = await _tblMateriasRepository.ObtenerTodos();
            var TblMateriassDTO = new List<ReadTblMateriasDTO>();

            foreach (var tblMaterias in tblMateriass)
            {
                var tblMateriasDTO = new ReadTblMateriasDTO
                {
                    lMateria_id = tblMaterias.lMateria_id,
                    sMateria_codigo = tblMaterias.sMateria_codigo,
                    sMateria_nombre = tblMaterias.sMateria_nombre,
                    sMateria_estado = tblMaterias.sMateria_estado
                };
                TblMateriassDTO.Add(tblMateriasDTO);
            }

            return TblMateriassDTO;
        }
    }
}
