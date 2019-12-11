using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Contacto
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tablaContacto = new DataTable();
        EntidadContacto Contactos;

        public EntidadContacto MostrarPersonaaContacto(int id_persona)
        {
            SqlCommand command = new SqlCommand("[PROC_MOSTRAR_contacto]", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_persona", id_persona);
            leer = command.ExecuteReader();
            tablaContacto.Load(leer);
            conexion.CerrarConexion();
            DataRow row = tablaContacto.Rows[0];
            Contactos = new EntidadContacto(
                id_persona,
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                row[4].ToString(),
                Convert.ToInt32(row[5].ToString()),
                row[5].ToString(),
                Convert.ToInt64(row[7].ToString())
                ); 
            return Contactos;
        }

        public void InsertPersonaContactoSinNumeroInt(EntidadContacto contacto)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_contacto", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_persona", contacto.Id_Persona);
            command.Parameters.AddWithValue("@estado",contacto.Estado);
            command.Parameters.AddWithValue("@ciudad", contacto.Ciudad);
            command.Parameters.AddWithValue("@colonia", contacto.Colonia);
            command.Parameters.AddWithValue("@calle", contacto.Calle);
            command.Parameters.AddWithValue("@n_ext", contacto.Numero_exterior);
            command.Parameters.AddWithValue("@n_int", contacto.Numero_interior);
            command.Parameters.AddWithValue("@telefono", contacto.Telefono);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void InsertPersonaContactoConNumeroInt(EntidadContacto contacto)
        {
            SqlCommand command = new SqlCommand("PROC_ALTA_contacto", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_persona", contacto.Id_Persona);
            command.Parameters.AddWithValue("@estado", contacto.Estado);
            command.Parameters.AddWithValue("@ciudad", contacto.Ciudad);
            command.Parameters.AddWithValue("@colonia", contacto.Colonia);
            command.Parameters.AddWithValue("@calle", contacto.Calle);
            command.Parameters.AddWithValue("@n_ext", contacto.Numero_exterior);
            command.Parameters.AddWithValue("@n_int", contacto.Numero_interior);
            command.Parameters.AddWithValue("@telefono", contacto.Telefono);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void UpdatePersonaContactoConNumeroInt(EntidadContacto contacto)
        {
            SqlCommand command = new SqlCommand("PROC_CAMBIO_contacto", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_persona", contacto.Id_Persona);
            command.Parameters.AddWithValue("@estado", contacto.Estado);
            command.Parameters.AddWithValue("@ciudad", contacto.Ciudad);
            command.Parameters.AddWithValue("@colonia", contacto.Colonia);
            command.Parameters.AddWithValue("@calle", contacto.Calle);
            command.Parameters.AddWithValue("@n_ext", contacto.Numero_exterior);
            command.Parameters.AddWithValue("@n_int", contacto.Numero_interior);
            command.Parameters.AddWithValue("@telefono", contacto.Telefono);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void UpdatePersonaContactoSinNumeroInt(EntidadContacto contacto)
        {
            SqlCommand command = new SqlCommand("PROC_CAMBIO_contacto", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_persona", contacto.Id_Persona);
            command.Parameters.AddWithValue("@estado", contacto.Estado);
            command.Parameters.AddWithValue("@ciudad", contacto.Ciudad);
            command.Parameters.AddWithValue("@colonia", contacto.Colonia);
            command.Parameters.AddWithValue("@calle", contacto.Calle);
            command.Parameters.AddWithValue("@n_ext", contacto.Numero_exterior);
            command.Parameters.AddWithValue("@telefono", contacto.Telefono);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void DeletePersonaContacto(EntidadContacto contacto)
        {
            SqlCommand command = new SqlCommand("PROC_BAJAusp_contacto", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_persona", contacto.Id_Persona);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }




        /*@id_persona int,
@estado varchar(50),
@ciudad varchar(60),
@colonia varchar(60),
@calle varchar(80),
@n_ext int,
@n_int char(5) = '1',
@telefono char(10)*/
    }
}
