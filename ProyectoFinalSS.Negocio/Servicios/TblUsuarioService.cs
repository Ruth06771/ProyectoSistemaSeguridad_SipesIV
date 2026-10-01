using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Negocio.DTOs.TblUsuarios;
using ProyectoFinalSS.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Servicios
{
    public class TblUsuariosService : ITblUsuariosService
    {
        private readonly ITblUsuariosRepository _tblUsuariosRepository;
        public TblUsuariosService(ITblUsuariosRepository tblUsuariosRepository)
        {
            _tblUsuariosRepository = tblUsuariosRepository;
        }
        public async Task Crear(CreateTblUsuariosDTO tblUsuarios)
        {
            TblUsuarios objTblUsuarios = new TblUsuarios
            {
                lPersonas_id = tblUsuarios.lPersonas_id,
                lPerfiles_id = tblUsuarios.lPerfiles_id,
                sUsuario_correo = tblUsuarios.sUsuario_correo,
                sUsuario_password = tblUsuarios.sUsuario_password,
                sUsuario_estado = tblUsuarios.sUsuario_estado
            };
            await _tblUsuariosRepository.Crear(objTblUsuarios);
        }

        public async Task Actualizar(UpdateTblUsuariosDTO tblUsuarios)
        {
            TblUsuarios objTblUsuarios = new TblUsuarios
            {
                lUsuarios_id = tblUsuarios.lUsuarios_id,
                lPersonas_id = tblUsuarios.lPersonas_id,
                lPerfiles_id = tblUsuarios.lPerfiles_id,
                sUsuario_correo = tblUsuarios.sUsuario_correo,
                sUsuario_password = tblUsuarios.sUsuario_password,
                sUsuario_estado = tblUsuarios.sUsuario_estado
            };
            await _tblUsuariosRepository.Actualizar(objTblUsuarios);
        }

        public async Task Eliminar(int idUsuarios)
        {
            await _tblUsuariosRepository.Eliminar(idUsuarios);
        }

        public async Task<ReadTblUsuariosDTO> ObtenerPorId(int idUsuarios)
        {
            var result = await _tblUsuariosRepository.ObtenerPorId(idUsuarios);
            if (result is null) return null;
            return new ReadTblUsuariosDTO
            {
                lUsuarios_id = result.lUsuarios_id,
                lPersonas_id = result.lPersonas_id,
                lPerfiles_id = result.lPerfiles_id,
                sUsuario_correo = result.sUsuario_correo,
                sUsuario_password = result.sUsuario_password,
                sUsuario_estado = result.sUsuario_estado
            };
        }

        public async Task<List<ReadTblUsuariosDTO>> ObtenerTodos()
        {
            var tblUsuarioss = await _tblUsuariosRepository.ObtenerTodos();
            var TblUsuariossDTO = new List<ReadTblUsuariosDTO>();

            foreach (var tblUsuarios in tblUsuarioss)
            {
                var tblUsuariosDTO = new ReadTblUsuariosDTO
                {
                    lUsuarios_id = tblUsuarios.lUsuarios_id,
                    lPersonas_id = tblUsuarios.lPersonas_id,
                    lPerfiles_id = tblUsuarios.lPerfiles_id,
                    sUsuario_correo = tblUsuarios.sUsuario_correo,
                    sUsuario_password = tblUsuarios.sUsuario_password,
                    sUsuario_estado = tblUsuarios.sUsuario_estado
                };
                TblUsuariossDTO.Add(tblUsuariosDTO);
            }

            return TblUsuariossDTO;
        }
    }
}
