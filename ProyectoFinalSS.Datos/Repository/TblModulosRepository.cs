using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblModulosRepository : ITblModulosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblModulosRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblModulos modulos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblmodulos_crear", new
            {
                sModulo_nm = modulos.sModulo_nm,
                sModulo_estado = modulos.sModulo_estado

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblModulos modulos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblmodulos_actualizar", new TblModulos
            {
                lModulo_id = modulos.lModulo_id,
                sModulo_nm = modulos.sModulo_nm,
                sModulo_estado = modulos.sModulo_estado
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idModulos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblmodulos_eliminar", new
            {
                lModulo_id = idModulos
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblModulos>> ObtenerTodos()
        {
            IEnumerable<TblModulos> resultado = await _database.GetData<TblModulos>("fn_tblmodulos_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblModulos> ObtenerPorId(int idModulos)
        {
            IEnumerable<TblModulos> resultado = await _database.GetData<TblModulos>("fn_tblmodulos_obtener_por_id", new
            {
                lModulo_id = idModulos
            });
            return resultado.FirstOrDefault();
        }
    }
}
