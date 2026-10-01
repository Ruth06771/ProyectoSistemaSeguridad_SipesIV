using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblModulos;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblModulosService : ITblModulosService
    {
        private readonly ITblModulosRepository _tblModulosRepository;
        public TblModulosService(ITblModulosRepository tblModulosRepository)
        {
            _tblModulosRepository = tblModulosRepository;
        }
        public async Task Crear(CreateTblModulosDTO tblModulos)
        {
            TblModulos objTblModulos = new TblModulos
            {
                sModulo_nm = tblModulos.sModulo_nm,
                sModulo_estado = tblModulos.sModulo_estado
            };
            await _tblModulosRepository.Crear(objTblModulos);
        }

        public async Task Actualizar(UpdateTblModulosDTO tblModulos)
        {
            TblModulos objTblModulos = new TblModulos
            {
                lModulo_id = tblModulos.lModulo_id,
                sModulo_nm = tblModulos.sModulo_nm,
                sModulo_estado = tblModulos.sModulo_estado
            };
            await _tblModulosRepository.Actualizar(objTblModulos);
        }

        public async Task Eliminar(int idModulos)
        {
            await _tblModulosRepository.Eliminar(idModulos);
        }

        public async Task<ReadTblModulosDTO> ObtenerPorId(int idModulos)
        {
            var result = await _tblModulosRepository.ObtenerPorId(idModulos);
            if (result is null) return null;
            return new ReadTblModulosDTO
            {
                lModulo_id = result.lModulo_id,
                sModulo_nm = result.sModulo_nm,
                sModulo_estado = result.sModulo_estado
            };
        }

        public async Task<List<ReadTblModulosDTO>> ObtenerTodos()
        {
            var tblModuloss = await _tblModulosRepository.ObtenerTodos();
            var TblModulossDTO = new List<ReadTblModulosDTO>();

            foreach (var tblModulos in tblModuloss)
            {
                var tblModulosDTO = new ReadTblModulosDTO
                {
                    lModulo_id = tblModulos.lModulo_id,
                    sModulo_nm = tblModulos.sModulo_nm,
                    sModulo_estado = tblModulos.sModulo_estado
                };
                TblModulossDTO.Add(tblModulosDTO);
            }

            return TblModulossDTO;
        }
    }
}
