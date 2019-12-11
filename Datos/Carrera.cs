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
    public class Carrera
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertCarrera(EntidadCarrera carrera)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_carreras", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@carrera", carrera.Carrera);
            command.Parameters.AddWithValue("@coordinador", carrera.Coordinador);

            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
