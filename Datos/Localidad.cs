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
    public class Localidad
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public void InsertLocalidad(EntidadLocalidad localidad)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_localidades", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_estados", localidad.IdEstado);
            command.Parameters.AddWithValue("@id_ciudades", localidad.IdCiudad);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
