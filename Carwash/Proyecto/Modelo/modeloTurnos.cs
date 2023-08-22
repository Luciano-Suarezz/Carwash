using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    class modeloTurnos
    {
        static MySqlConnection miConexion = Conexion.getConexion();
        static string sql = "";
        static MySqlDataReader reader;

        public bool existeTurnoo(Turnos turno)
        {
            MySqlConnection miConexion = Conexion.getConexion();
            bool rta = false;
            miConexion.Open();
            string sql = "select * from turnos where patente Like @Patente";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Patente", turno.Patente);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }

        public bool existePatenteFecha(Turnos turno)
        {
            bool rta = false;
            miConexion.Open();
            sql = "select * from turnos where patente Like '" + turno.Patente + "' and fecha = '" + turno.Fecha.ToString("yyyy-MM-dd") + "' ;";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }

        public bool registrarTurnoo(Turnos turno)
        {
            miConexion.Open();
            sql = "INSERT INTO turnos (fecha, hora, patente, tiempoEstimado, tipoLavado, descripcion, monto)" + " VALUES(@Fecha, @Hora, @Patente, @Estimado, @Tipolavado, @Descripcion, @Monto)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Fecha", turno.Fecha.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@Patente", turno.Patente);
            comando.Parameters.AddWithValue("@Hora", turno.Hora);
            comando.Parameters.AddWithValue("@Estimado", turno.Estimado);
            comando.Parameters.AddWithValue("@Tipolavado", turno.Tipolavado);
            comando.Parameters.AddWithValue("@Monto", turno.Monto);
            comando.Parameters.AddWithValue("@Descripcion", turno.Descripcion);
            int tuplas = comando.ExecuteNonQuery();
            if (tuplas > 0)
            {
                miConexion.Close();
                return true;
            }
            else
            {
                miConexion.Close();
                return false;

            }
        }
    }
}
