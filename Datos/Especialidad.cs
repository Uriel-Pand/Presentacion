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
    public class Especialidad
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertEspecialidad(EntidadEspecialidad especialidad)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_especialidades", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@especialidad", especialidad.Especialidad);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
