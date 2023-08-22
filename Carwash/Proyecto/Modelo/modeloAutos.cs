using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    class modeloAutos
    {
        static MySqlConnection miConexion = Conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;

        public bool existePatente(Autos socio)
        {
            bool rta = false;
            miConexion.Open();
            sql = "select * from auto where patente Like @Patente";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Patente", socio.Patente);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }

        public bool existeTurno(Autos socio)
        {
            MySqlConnection miConexion = Conexion.getConexion();
            bool rta = false;
            miConexion.Open();
            string sql = "select * from turnos where patente Like @Patente";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Patente", socio.Patente);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool registrarSocio(Autos socio)
        {
            miConexion.Open();
            sql = "INSERT INTO auto (patente, marca, modelo, año, dni)" + " VALUES(@Patente, @Marca, @Modelo, @Año, @Dni)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Patente", socio.Patente);
            comando.Parameters.AddWithValue("@Marca", socio.Marca);
            comando.Parameters.AddWithValue("@Modelo", socio.Modelo);
            comando.Parameters.AddWithValue("@Año", socio.Año);
            comando.Parameters.AddWithValue("@Dni", socio.Dni);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }

    }
}
