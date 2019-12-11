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
    public class Calificacion
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertCalificacion(EntidadCalificacion calificacion)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_calificaciones", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_grupos_alumnos", calificacion.IdGruposAlumno);
            command.Parameters.AddWithValue("@calificacion", calificacion.Tema);
            command.Parameters.AddWithValue("@tema", calificacion.Tema);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
