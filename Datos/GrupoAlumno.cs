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
    public class GrupoAlumno
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable Table;

        public void InsertGrupoAlumno(EntidadGrupoAlumno grupoAlumno)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_grupos_alumnos", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@matricula", grupoAlumno.Matricula);
            command.Parameters.AddWithValue("@clave_grupos", grupoAlumno.ClaveGrupo);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable MostrarMisMaterias(string matricula)
        {
            SqlCommand command = new SqlCommand("PROC_MOSTRAR_mis_materias", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Matricula", matricula);
            leer = command.ExecuteReader();
            Table = new DataTable();
            Table.Load(leer);
            conexion.CerrarConexion();
            return Table;
        }

        public int DeleteGrupoAlumno(EntidadGrupoAlumno grupoAlumno)
        {
            try
            {
                SqlCommand command = new SqlCommand("[PROC_BAJAusp_grupos_alumnosDelete]", conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@matricula", grupoAlumno.Matricula);
                command.Parameters.AddWithValue("@clave_grupos", grupoAlumno.ClaveGrupo);
                command.ExecuteNonQuery();
                conexion.CerrarConexion();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

    }
}
