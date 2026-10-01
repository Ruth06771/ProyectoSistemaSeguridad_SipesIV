using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblCentroAlertasService : ITblCentroAlertasService
    {
        private readonly ITblCentroAlertasRepository _tblCentroAlertasRepository;
        public TblCentroAlertasService(ITblCentroAlertasRepository tblCentroAlertasRepository)
        {
            _tblCentroAlertasRepository = tblCentroAlertasRepository;
        }
        public async Task Crear(CreateTblCentroAlertasDTO tblCentroAlertas)
        {
            TblCentroAlertas objTblCentroAlertas = new TblCentroAlertas
            {
                lArea_id = tblCentroAlertas.lArea_id,
                lRegistro_accesos_id = tblCentroAlertas.lRegistro_accesos_id,
                sCentroAlertas_fecha_hora = tblCentroAlertas.sCentroAlertas_fecha_hora
            };
            await _tblCentroAlertasRepository.Crear(objTblCentroAlertas);
        }

        public async Task Actualizar(UpdateTblCentroAlertasDTO tblCentroAlertas)
        {
            TblCentroAlertas objTblCentroAlertas = new TblCentroAlertas
            {
                lCentroAlertas_id = tblCentroAlertas.lCentroAlertas_id,
                lArea_id = tblCentroAlertas.lArea_id,
                lRegistro_accesos_id = tblCentroAlertas.lRegistro_accesos_id,
                sCentroAlertas_fecha_hora = tblCentroAlertas.sCentroAlertas_fecha_hora
            };
            await _tblCentroAlertasRepository.Actualizar(objTblCentroAlertas);
        }

        public async Task Eliminar(int idCentroAlertas)
        {
            await _tblCentroAlertasRepository.Eliminar(idCentroAlertas);
        }

        public async Task<ReadTblCentroAlertasDTO> ObtenerPorId(int idCentroAlertas)
        {
            var result = await _tblCentroAlertasRepository.ObtenerPorId(idCentroAlertas);
            if (result is null) return null;
            return new ReadTblCentroAlertasDTO
            {
                lCentroAlertas_id = result.lCentroAlertas_id,
                lArea_id = result.lArea_id,
                lRegistro_accesos_id = result.lRegistro_accesos_id,
                sCentroAlertas_fecha_hora = result.sCentroAlertas_fecha_hora
            };
        }

        public async Task<List<ReadTblCentroAlertasDTO>> ObtenerTodos()
        {
            var tblCentroAlertass = await _tblCentroAlertasRepository.ObtenerTodos();
            var TblCentroAlertassDTO = new List<ReadTblCentroAlertasDTO>();

            foreach (var tblCentroAlertas in tblCentroAlertass)
            {
                var tblCentroAlertasDTO = new ReadTblCentroAlertasDTO
                {
                    lCentroAlertas_id = tblCentroAlertas.lCentroAlertas_id,
                    lArea_id = tblCentroAlertas.lArea_id,
                    lRegistro_accesos_id = tblCentroAlertas.lRegistro_accesos_id,
                    sCentroAlertas_fecha_hora = tblCentroAlertas.sCentroAlertas_fecha_hora
                };
                TblCentroAlertassDTO.Add(tblCentroAlertasDTO);
            }

            return TblCentroAlertassDTO;
        }
    }
}
