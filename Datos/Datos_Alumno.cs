using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Datos_Alumno
    {

        Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tablaPersona = new DataTable();

        public void InsertDatosAlumno(EntidadPersona personas)
        {

            SqlCommand command = new SqlCommand("PROC_ALTA_datos_alumno", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@matricula", personas.Matricula);
            command.Parameters.AddWithValue("@carrera", personas.Carrera);
            command.Parameters.AddWithValue("@especialidad", personas.Especialidad);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();

        }


        public void UpdateDatosAlumno(EntidadPersona personas)
        {

            SqlCommand command = new SqlCommand("PROC_CAMBIO_datos_alumno", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@matricula", personas.Matricula);
            command.Parameters.AddWithValue("@carrera", personas.Carrera);
            command.Parameters.AddWithValue("@especialidad", personas.Especialidad);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}
