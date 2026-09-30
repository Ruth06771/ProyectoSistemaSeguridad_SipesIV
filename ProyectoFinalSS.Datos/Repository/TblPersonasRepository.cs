using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblPersonasRepository : ITblPersonasRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblPersonasRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblPersonas personas)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpersonas_crear", new
            {
                sPersonas_nm = personas.sPersonas_nm,
                sPersonas_aps = personas.sPersonas_aps,
                sPersonas_fecha_nacimiento = personas.sPersonas_fecha_nacimiento,
                sPersonas_correo = personas.sPersonas_correo,
                sPersonas_telefono = personas.sPersonas_telefono,
                sPersonas_numero_carnet = personas.sPersonas_numero_carnet,
                sPersonas_sexo = personas.sPersonas_sexo,
                sPersonas_tipo_sangre = personas.sPersonas_tipo_sangre,
                sPersonas_estado = personas.sPersonas_estado,
                sPersonas_fecha_registro = personas.sPersonas_fecha_registro,
                sPersonas_direccion = personas.sPersonas_direccion,
                sPersonas_tipo_persona = personas.sPersonas_tipo_persona,
                sTarjetas_uid = personas.sTarjetas_uid,
                sTarjetas_pin = personas.sTarjetas_pin,
                sTarjetas_estado = personas.sTarjetas_estado

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblPersonas personas)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpersonas_actualizar", new TblPersonas
            {
                lPersonas_id = personas.lPersonas_id,
                sPersonas_nm = personas.sPersonas_nm,
                sPersonas_aps = personas.sPersonas_aps,
                sPersonas_fecha_nacimiento = personas.sPersonas_fecha_nacimiento,
                sPersonas_correo = personas.sPersonas_correo,
                sPersonas_telefono = personas.sPersonas_telefono,
                sPersonas_numero_carnet = personas.sPersonas_numero_carnet,
                sPersonas_sexo = personas.sPersonas_sexo,
                sPersonas_tipo_sangre = personas.sPersonas_tipo_sangre,
                sPersonas_estado = personas.sPersonas_estado,
                sPersonas_fecha_registro = personas.sPersonas_fecha_registro,
                sPersonas_direccion = personas.sPersonas_direccion,
                sPersonas_tipo_persona = personas.sPersonas_tipo_persona,
                sTarjetas_uid = personas.sTarjetas_uid,
                sTarjetas_pin = personas.sTarjetas_pin,
                sTarjetas_estado = personas.sTarjetas_estado
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idPersonas)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpersonas_eliminar", new
            {
                lPersona_id = idPersonas
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblPersonas>> ObtenerTodos()
        {
            IEnumerable<TblPersonas> resultado = await _database.GetData<TblPersonas>("fn_tblpersonas_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblPersonas> ObtenerPorId(int idPersonas)
        {
            IEnumerable<TblPersonas> resultado = await _database.GetData<TblPersonas>("fn_tblpersonas_obtener_por_id", new
            {
                lPersona_id = idPersonas
            });
            return resultado.FirstOrDefault();
        }
    }
}
