using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Especialidades
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertCarrera(EntidadEspecialidad especialidad)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_especialidades", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@especialidad", especialidad.Especialidad);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
