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
    public class Ciudad
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertCiudad(EntidadCiudad ciudad)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_ciudades", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ciudada", ciudad.Ciudada);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
