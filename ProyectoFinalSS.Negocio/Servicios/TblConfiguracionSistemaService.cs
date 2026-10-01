using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblConfiguracionSistema;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblConfiguracionSistemaService : ITblConfiguracionSistemaService
    {
        private readonly ITblConfiguracionSistemaRepository _tblConfiguracionSistemaRepository;
        public TblConfiguracionSistemaService(ITblConfiguracionSistemaRepository tblConfiguracionSistemaRepository)
        {
            _tblConfiguracionSistemaRepository = tblConfiguracionSistemaRepository;
        }
        public async Task Crear(CreateTblConfiguracionSistemaDTO tblConfiguracionSistema)
        {
            TblConfiguracionSistema objTblConfiguracionSistema = new TblConfiguracionSistema
            {
                lUsuario_id = tblConfiguracionSistema.lUsuario_id,
                sConfig_intentos_fallidos_bloqueo = tblConfiguracionSistema.sConfig_intentos_fallidos_bloqueo,
                sConfig_inactividad_sesion = tblConfiguracionSistema.sConfig_inactividad_sesion,
                sConfig_tolerancia_marcaje_minutos = tblConfiguracionSistema.sConfig_tolerancia_marcaje_minutos,
                sConfig_tiempo_antipassck = tblConfiguracionSistema.sConfig_tiempo_antipassck,
                sConfig_alertas_intentos_denegados = tblConfiguracionSistema.sConfig_alertas_intentos_denegados,
                sConfig_fecha_actualizacion = tblConfiguracionSistema.sConfig_fecha_actualizacion
            };
            await _tblConfiguracionSistemaRepository.Crear(objTblConfiguracionSistema);
        }

        public async Task Actualizar(UpdateTblConfiguracionSistemaDTO tblConfiguracionSistema)
        {
            TblConfiguracionSistema objTblConfiguracionSistema = new TblConfiguracionSistema
            {
                lConfig_id = tblConfiguracionSistema.lConfig_id,
                lUsuario_id = tblConfiguracionSistema.lUsuario_id,
                sConfig_intentos_fallidos_bloqueo = tblConfiguracionSistema.sConfig_intentos_fallidos_bloqueo,
                sConfig_inactividad_sesion = tblConfiguracionSistema.sConfig_inactividad_sesion,
                sConfig_tolerancia_marcaje_minutos = tblConfiguracionSistema.sConfig_tolerancia_marcaje_minutos,
                sConfig_tiempo_antipassck = tblConfiguracionSistema.sConfig_tiempo_antipassck,
                sConfig_alertas_intentos_denegados = tblConfiguracionSistema.sConfig_alertas_intentos_denegados,
                sConfig_fecha_actualizacion = tblConfiguracionSistema.sConfig_fecha_actualizacion
            };
            await _tblConfiguracionSistemaRepository.Actualizar(objTblConfiguracionSistema);
        }

        public async Task Eliminar(int idConfiguracionSistema)
        {
            await _tblConfiguracionSistemaRepository.Eliminar(idConfiguracionSistema);
        }

        public async Task<ReadTblConfiguracionSistemaDTO> ObtenerPorId(int idConfiguracionSistema)
        {
            var result = await _tblConfiguracionSistemaRepository.ObtenerPorId(idConfiguracionSistema);
            if (result is null) return null;
            return new ReadTblConfiguracionSistemaDTO
            {
                lConfig_id = result.lConfig_id,
                lUsuario_id = result.lUsuario_id,
                sConfig_intentos_fallidos_bloqueo = result.sConfig_intentos_fallidos_bloqueo,
                sConfig_inactividad_sesion = result.sConfig_inactividad_sesion,
                sConfig_tolerancia_marcaje_minutos = result.sConfig_tolerancia_marcaje_minutos,
                sConfig_tiempo_antipassck = result.sConfig_tiempo_antipassck,
                sConfig_alertas_intentos_denegados = result.sConfig_alertas_intentos_denegados,
                sConfig_fecha_actualizacion = result.sConfig_fecha_actualizacion
            };
        }

        public async Task<List<ReadTblConfiguracionSistemaDTO>> ObtenerTodos()
        {
            var tblConfiguracionSistemas = await _tblConfiguracionSistemaRepository.ObtenerTodos();
            var TblConfiguracionSistemasDTO = new List<ReadTblConfiguracionSistemaDTO>();

            foreach (var tblConfiguracionSistema in tblConfiguracionSistemas)
            {
                var tblConfiguracionSistemaDTO = new ReadTblConfiguracionSistemaDTO
                {
                    lConfig_id = tblConfiguracionSistema.lConfig_id,
                    lUsuario_id = tblConfiguracionSistema.lUsuario_id,
                    sConfig_intentos_fallidos_bloqueo = tblConfiguracionSistema.sConfig_intentos_fallidos_bloqueo,
                    sConfig_inactividad_sesion = tblConfiguracionSistema.sConfig_inactividad_sesion,
                    sConfig_tolerancia_marcaje_minutos = tblConfiguracionSistema.sConfig_tolerancia_marcaje_minutos,
                    sConfig_tiempo_antipassck = tblConfiguracionSistema.sConfig_tiempo_antipassck,
                    sConfig_alertas_intentos_denegados = tblConfiguracionSistema.sConfig_alertas_intentos_denegados,
                    sConfig_fecha_actualizacion = tblConfiguracionSistema.sConfig_fecha_actualizacion
                };
                TblConfiguracionSistemasDTO.Add(tblConfiguracionSistemaDTO);
            }

            return TblConfiguracionSistemasDTO;
        }
    }
}

