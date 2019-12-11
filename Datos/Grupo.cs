using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Grupo
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable table = new DataTable();
        public void InsertGrupo(EntidadGrupo grupo)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_grupos", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@clave_grupos", grupo.ClaveGrupo);
            command.Parameters.AddWithValue("@id_materias", grupo.IdMateria);
            command.Parameters.AddWithValue("@id_profesor", grupo.IdProfesor);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void UpdateGrupo(EntidadGrupo grupo)
        {
            SqlCommand command = new SqlCommand("PROC_CAMBIO_grupos", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@clave_grupos", grupo.ClaveGrupo);
            command.Parameters.AddWithValue("@id_materias", grupo.IdMateria);
            command.Parameters.AddWithValue("@id_profesor", grupo.IdProfesor);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public DataTable Mostrar(string grupo)
        {
            SqlCommand command = new SqlCommand("PROC_MOSTRAR_alumno_grupo", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Clave_grupo", grupo);
            leer = command.ExecuteReader();
            table.Load(leer);
            conexion.CerrarConexion();

            return table;
        }
    }
}
