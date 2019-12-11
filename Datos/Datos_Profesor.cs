using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Datos_Profesor
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tablaPersona = new DataTable();


        public DataTable MostrarPersona()
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_datos_profesor", conexion.AbrirConexion());

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "select * from personas";
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            tablaPersona.Load(leer);
            conexion.CerrarConexion();
            return tablaPersona;
        }

        public void InsertDatosProfesor(Entidad_datos_profesor profesor)
        {

            SqlCommand command = new SqlCommand("PROC_ALTA_datos_profesor", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@matricula", profesor.Matricula);
            command.Parameters.AddWithValue("@academia", profesor.Academia);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        public void ActulizarDatosProfesor(Entidad_datos_profesor profesor)
        {

            SqlCommand command = new SqlCommand("PROC_CAMBIO_datos_profesor", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@matricula", profesor.Matricula);
            command.Parameters.AddWithValue("@academia", profesor.Academia);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

    }
}
