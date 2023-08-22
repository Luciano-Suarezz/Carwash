using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    class modeloPersona
    {
        static MySqlConnection miConexion = Conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public bool existeDni(Persona persona)
        {
            bool rta = false;
            miConexion.Open();
            sql = "select * from persona where dni Like @Dni";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Dni", persona.Dni);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool existeAuto(Persona persona)
        {
            MySqlConnection miConexion = Conexion.getConexion();
            bool rta = false;
            miConexion.Open();
            string sql = "select * from auto where dni Like @Dni";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Dni", persona.Dni);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }

        public bool registrarPersona(Persona persona)
        {
            miConexion.Open();
            sql = "INSERT INTO persona (nombre, dni, telefono)" + " VALUES(@Nombre, @Dni, @Telefono)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
            comando.Parameters.AddWithValue("@Telefono", persona.Telefono);
            comando.Parameters.AddWithValue("@Dni", persona.Dni);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}
