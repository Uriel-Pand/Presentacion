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
    public class CarreraEspecialidad
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void InsertCarreraEspecialidad(EntidadCarreraEspecialidad carrera)
        {
            SqlCommand command = new SqlCommand("[PROC_ALTA_carrera_especialidad]", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@carrera", carrera.IdCarrera);
            command.Parameters.AddWithValue("@especialidad", carrera.IdEspecialidad);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
