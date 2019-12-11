using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Academia
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();


        public void InsertAcademia(EntidadAcademia academia)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_academias", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@academia", academia.Academia);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
