using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblLectores;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblLectoresService : ITblLectoresService
    {
        private readonly ITblLectoresRepository _tblLectoresRepository;
        public TblLectoresService(ITblLectoresRepository tblLectoresRepository)
        {
            _tblLectoresRepository = tblLectoresRepository;
        }
        public async Task Crear(CreateTblLectoresDTO tblLectores)
        {
            TblLectores objTblLectores = new TblLectores
            {
                lArea_id = tblLectores.lArea_id,
                sLector_codigo = tblLectores.sLector_codigo,
                sLector_ip = tblLectores.sLector_ip,
                sLector_mac = tblLectores.sLector_mac,
                sLector_tipo_acceso = tblLectores.sLector_tipo_acceso,
                sLector_estado = tblLectores.sLector_estado,
                sLector_ultimo_ping = tblLectores.sLector_ultimo_ping
            };
            await _tblLectoresRepository.Crear(objTblLectores);
        }

        public async Task Actualizar(UpdateTblLectoresDTO tblLectores)
        {
            TblLectores objTblLectores = new TblLectores
            {
                lLector_id = tblLectores.lLector_id,
                lArea_id = tblLectores.lArea_id,
                sLector_codigo = tblLectores.sLector_codigo,
                sLector_ip = tblLectores.sLector_ip,
                sLector_mac = tblLectores.sLector_mac,
                sLector_tipo_acceso = tblLectores.sLector_tipo_acceso,
                sLector_estado = tblLectores.sLector_estado,
                sLector_ultimo_ping = tblLectores.sLector_ultimo_ping
            };
            await _tblLectoresRepository.Actualizar(objTblLectores);
        }

        public async Task Eliminar(int idLectores)
        {
            await _tblLectoresRepository.Eliminar(idLectores);
        }

        public async Task<ReadTblLectoresDTO> ObtenerPorId(int idLectores)
        {
            var result = await _tblLectoresRepository.ObtenerPorId(idLectores);
            if (result is null) return null;
            return new ReadTblLectoresDTO
            {
                lLector_id = result.lLector_id,
                lArea_id = result.lArea_id,
                sLector_codigo = result.sLector_codigo,
                sLector_ip = result.sLector_ip,
                sLector_mac = result.sLector_mac,
                sLector_tipo_acceso = result.sLector_tipo_acceso,
                sLector_estado = result.sLector_estado,
                sLector_ultimo_ping = result.sLector_ultimo_ping
            };
        }

        public async Task<List<ReadTblLectoresDTO>> ObtenerTodos()
        {
            var tblLectoress = await _tblLectoresRepository.ObtenerTodos();
            var TblLectoressDTO = new List<ReadTblLectoresDTO>();

            foreach (var tblLectores in tblLectoress)
            {
                var tblLectoresDTO = new ReadTblLectoresDTO
                {
                    lLector_id = tblLectores.lLector_id,
                    lArea_id = tblLectores.lArea_id,
                    sLector_codigo = tblLectores.sLector_codigo,
                    sLector_ip = tblLectores.sLector_ip,
                    sLector_mac = tblLectores.sLector_mac,
                    sLector_tipo_acceso = tblLectores.sLector_tipo_acceso,
                    sLector_estado = tblLectores.sLector_estado,
                    sLector_ultimo_ping = tblLectores.sLector_ultimo_ping
                };
                TblLectoressDTO.Add(tblLectoresDTO);
            }

            return TblLectoressDTO;
        }
    }
}
