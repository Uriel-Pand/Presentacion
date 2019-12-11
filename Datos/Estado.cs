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
    public class Estado
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public void InsertEstado(EntidadEstado estado)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_estados", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@estado", estado.Estado);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


    }
}
