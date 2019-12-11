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
    public class Calle
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertCalle(EntidadCalle calle)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_calles", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@calle", calle.Calle);

            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
