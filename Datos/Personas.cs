using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Personas
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tablaPersona = new DataTable();
        EntidadPersona Persona;
        public EntidadPersona MostrarPersonaaAlumno(String matricula)
        {
            SqlCommand command = new SqlCommand("PROC_MOSTRAR_personas_alumno", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@matricula",matricula);
            leer = command.ExecuteReader();
            tablaPersona.Load(leer);
            conexion.CerrarConexion();
            DataRow row = tablaPersona.Rows[0];
            Persona = new EntidadPersona(
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                row[5].ToString(),
                row[4].ToString(),
                row[6].ToString(),
                Convert.ToInt32(row[0].ToString())
                );
            return Persona;
        }

        public EntidadPersona MostrarPersonaProfesor(String matricula)
        {
            SqlCommand command = new SqlCommand("PROC_MOSTRAR_personas_profesor", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@matricula", matricula);
            leer = command.ExecuteReader();
            tablaPersona.Load(leer);
            conexion.CerrarConexion();
            DataRow row = tablaPersona.Rows[0];
            Persona = new EntidadPersona(
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                row[5].ToString(),
                row[4].ToString(),
                row[6].ToString(),
                Convert.ToInt32(row[0].ToString())
                );
            return Persona;
        }

        public EntidadPersona InsertPersonaAlumno(EntidadPersona persona)
        {

            SqlCommand command = new SqlCommand("PROC_ALTA_personas_alumno", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", persona.Nombre);
            command.Parameters.AddWithValue("@apellido_paterno", persona.Apellido_paterno);
            command.Parameters.AddWithValue("@apellido_materno", persona.Apellido_materno);
            command.Parameters.AddWithValue("@sexo", persona.Sexo);
            command.Parameters.AddWithValue("@curp", persona.Curp);
            command.Parameters.AddWithValue("@fecha_nacimiento", persona.Fecha_nacimiento);

            leer = command.ExecuteReader();
            tablaPersona.Load(leer);

            DataRow datarow = tablaPersona.Rows[0];

            persona.Matricula = datarow["Matricula"].ToString();
            persona.Id_persona = Convert.ToInt32(datarow[2].ToString());
            conexion.CerrarConexion();
            return persona;

        }

        public EntidadPersona InsertPersonaProfesor(EntidadPersona persona)
        {

            SqlCommand command = new SqlCommand("PROC_ALTA_personas_profesor", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", persona.Nombre);
            command.Parameters.AddWithValue("@apellido_paterno", persona.Apellido_paterno);
            command.Parameters.AddWithValue("@apellido_materno", persona.Apellido_materno);
            command.Parameters.AddWithValue("@sexo", persona.Sexo);
            command.Parameters.AddWithValue("@curp", persona.Curp);
            command.Parameters.AddWithValue("@fecha_nacimiento", persona.Fecha_nacimiento);

            leer = command.ExecuteReader();
            tablaPersona.Load(leer);

            DataRow datarow = tablaPersona.Rows[0];

            persona.Matricula = datarow[0].ToString();
            persona.Id_persona = Convert.ToInt32(datarow[1].ToString());
            conexion.CerrarConexion();
            return persona;

        }

        public int UpdatePersona(EntidadPersona persona)
        {
            try
            {
                SqlCommand command = new SqlCommand("PROC_CAMBIO_personas", conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_personas", persona.Id_persona);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido_paterno", persona.Apellido_paterno);
                command.Parameters.AddWithValue("@apellido_materno", persona.Apellido_materno);
                command.Parameters.AddWithValue("@sexo", persona.Sexo);
                command.Parameters.AddWithValue("@curp", persona.Curp);
                command.Parameters.AddWithValue("@fecha_nacimiento", persona.Fecha_nacimiento);
                command.ExecuteNonQuery();
                conexion.CerrarConexion();
                return 1;
            }
            catch
            {
                return 0;
            }
        }


        public int DeletePersonaAlumno(EntidadPersona persona)
        {

            SqlCommand command = new SqlCommand("PROC_BAJAusp_alumnosDelete", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@matricula", persona.Matricula);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();

            command = new SqlCommand("PROC_BAJAusp_personasDelete", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p", persona.Id_persona);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            return 1;
        }

        public int DeletePersonaProfesores(EntidadPersona persona)
        {
            SqlCommand command = new SqlCommand("PROC_BAJAusp_profesoresDelete", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_profesor", persona.Matricula);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();

            command = new SqlCommand("PROC_BAJAusp_personasDelete", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p", persona.Id_persona);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            return 1;
        }

    }




}