using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Materia
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public void InsertMateria(EntidadMateria materia)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_materias", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_materias", materia.IdMaterias);
            command.Parameters.AddWithValue("@materia", materia.Materia);
            command.Parameters.AddWithValue("@horas_teoricas", materia.HorasTeoricas);
            command.Parameters.AddWithValue("@horas_practicas", materia.HorasPracticas);
            command.Parameters.AddWithValue("@creditos", materia.Creditos);
            command.Parameters.AddWithValue("@id_carreras", materia.IdCarreras);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void UpdateMateria(EntidadMateria materia)
        {
            SqlCommand command = new SqlCommand("PROC_CAMBIO_materias", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_materia", materia.IdMaterias);
            command.Parameters.AddWithValue("@materia", materia.Materia);
            command.Parameters.AddWithValue("@horas_teoricas", materia.HorasTeoricas);
            command.Parameters.AddWithValue("@horas_practicas", materia.HorasPracticas);
            command.Parameters.AddWithValue("@creditos", materia.Creditos);
            command.Parameters.AddWithValue("@carrera", materia.IdCarreras);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void DeleteMateria(EntidadMateria materia)
        {
            SqlCommand command = new SqlCommand("PROC_BAJAusp_materias", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_materia", materia.IdMaterias);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
