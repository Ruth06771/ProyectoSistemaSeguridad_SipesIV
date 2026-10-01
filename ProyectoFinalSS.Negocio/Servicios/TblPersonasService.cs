using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblPersonas;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblPersonasService : ITblPersonasService
    {
        private readonly ITblPersonasRepository _tblPersonasRepository;
        public TblPersonasService(ITblPersonasRepository tblPersonasRepository)
        {
            _tblPersonasRepository = tblPersonasRepository;
        }
        public async Task Crear(CreateTblPersonasDTO tblPersonas)
        {
            TblPersonas objTblPersonas = new TblPersonas
            {
                sPersonas_nm = tblPersonas.sPersonas_nm,
                sPersonas_aps = tblPersonas.sPersonas_aps,
                sPersonas_fecha_nacimiento = tblPersonas.sPersonas_fecha_nacimiento,
                sPersonas_correo = tblPersonas.sPersonas_correo,
                sPersonas_telefono = tblPersonas.sPersonas_telefono,
                sPersonas_numero_carnet = tblPersonas.sPersonas_numero_carnet,
                sPersonas_sexo = tblPersonas.sPersonas_sexo,
                sPersonas_tipo_sangre = tblPersonas.sPersonas_tipo_sangre,
                sPersonas_estado = tblPersonas.sPersonas_estado,
                sPersonas_fecha_registro = tblPersonas.sPersonas_fecha_registro,
                sPersonas_direccion = tblPersonas.sPersonas_direccion,
                sPersonas_tipo_persona = tblPersonas.sPersonas_tipo_persona,
                sTarjetas_uid = tblPersonas.sTarjetas_uid,
                sTarjetas_pin = tblPersonas.sTarjetas_pin,
                sTarjetas_estado = tblPersonas.sTarjetas_estado
            };
            await _tblPersonasRepository.Crear(objTblPersonas);
        }

        public async Task Actualizar(UpdateTblPersonasDTO tblPersonas)
        {
            TblPersonas objTblPersonas = new TblPersonas
            {
                lPersonas_id = tblPersonas.lPersonas_id,
                sPersonas_nm = tblPersonas.sPersonas_nm,
                sPersonas_aps = tblPersonas.sPersonas_aps,
                sPersonas_fecha_nacimiento = tblPersonas.sPersonas_fecha_nacimiento,
                sPersonas_correo = tblPersonas.sPersonas_correo,
                sPersonas_telefono = tblPersonas.sPersonas_telefono,
                sPersonas_numero_carnet = tblPersonas.sPersonas_numero_carnet,
                sPersonas_sexo = tblPersonas.sPersonas_sexo,
                sPersonas_tipo_sangre = tblPersonas.sPersonas_tipo_sangre,
                sPersonas_estado = tblPersonas.sPersonas_estado,
                sPersonas_fecha_registro = tblPersonas.sPersonas_fecha_registro,
                sPersonas_direccion = tblPersonas.sPersonas_direccion,
                sPersonas_tipo_persona = tblPersonas.sPersonas_tipo_persona,
                sTarjetas_uid = tblPersonas.sTarjetas_uid,
                sTarjetas_pin = tblPersonas.sTarjetas_pin,
                sTarjetas_estado = tblPersonas.sTarjetas_estado
            };
            await _tblPersonasRepository.Actualizar(objTblPersonas);
        }

        public async Task Eliminar(int idPersonas)
        {
            await _tblPersonasRepository.Eliminar(idPersonas);
        }

        public async Task<ReadTblPersonasDTO> ObtenerPorId(int idPersonas)
        {
            var result = await _tblPersonasRepository.ObtenerPorId(idPersonas);
            if (result is null) return null;
            return new ReadTblPersonasDTO
            {
                lPersonas_id = result.lPersonas_id,
                sPersonas_nm = result.sPersonas_nm,
                sPersonas_aps = result.sPersonas_aps,
                sPersonas_fecha_nacimiento = result.sPersonas_fecha_nacimiento,
                sPersonas_correo = result.sPersonas_correo,
                sPersonas_telefono = result.sPersonas_telefono,
                sPersonas_numero_carnet = result.sPersonas_numero_carnet,
                sPersonas_sexo = result.sPersonas_sexo,
                sPersonas_tipo_sangre = result.sPersonas_tipo_sangre,
                sPersonas_estado = result.sPersonas_estado,
                sPersonas_fecha_registro = result.sPersonas_fecha_registro,
                sPersonas_direccion = result.sPersonas_direccion,
                sPersonas_tipo_persona = result.sPersonas_tipo_persona,
                sTarjetas_uid = result.sTarjetas_uid,
                sTarjetas_pin = result.sTarjetas_pin,
                sTarjetas_estado = result.sTarjetas_estado
            };
        }

        public async Task<List<ReadTblPersonasDTO>> ObtenerTodos()
        {
            var tblPersonass = await _tblPersonasRepository.ObtenerTodos();
            var TblPersonassDTO = new List<ReadTblPersonasDTO>();

            foreach (var tblPersonas in tblPersonass)
            {
                var tblPersonasDTO = new ReadTblPersonasDTO
                {
                    lPersonas_id = tblPersonas.lPersonas_id,
                    sPersonas_nm = tblPersonas.sPersonas_nm,
                    sPersonas_aps = tblPersonas.sPersonas_aps,
                    sPersonas_fecha_nacimiento = tblPersonas.sPersonas_fecha_nacimiento,
                    sPersonas_correo = tblPersonas.sPersonas_correo,
                    sPersonas_telefono = tblPersonas.sPersonas_telefono,
                    sPersonas_numero_carnet = tblPersonas.sPersonas_numero_carnet,
                    sPersonas_sexo = tblPersonas.sPersonas_sexo,
                    sPersonas_tipo_sangre = tblPersonas.sPersonas_tipo_sangre,
                    sPersonas_estado = tblPersonas.sPersonas_estado,
                    sPersonas_fecha_registro = tblPersonas.sPersonas_fecha_registro,
                    sPersonas_direccion = tblPersonas.sPersonas_direccion,
                    sPersonas_tipo_persona = tblPersonas.sPersonas_tipo_persona,
                    sTarjetas_uid = tblPersonas.sTarjetas_uid,
                    sTarjetas_pin = tblPersonas.sTarjetas_pin,
                    sTarjetas_estado = tblPersonas.sTarjetas_estado
                };
                TblPersonassDTO.Add(tblPersonasDTO);
            }

            return TblPersonassDTO;
        }
    }
}