using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Colonia
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertColonia(EntidadColonia colonia)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_colonias", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@colonia", colonia.Colonia);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
