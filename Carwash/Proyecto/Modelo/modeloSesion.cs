using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    class modeloSesion
    {
        private static MySqlConnection miConexion = Conexion.getConexion();
        private static string sql = "";
        private  static MySqlCommand comando;
        private static MySqlDataReader reader;

        public Usuarios miUsuario(string usuario)
        {
            Usuarios user = null;
            miConexion.Open();
            sql = "Select * from usuarios where User Like @user";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@User", usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = new Usuarios();
                    user.Id = int.Parse(reader["idUser"].ToString());
                    user.Usuario = reader["User"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Nombre = reader["Nombre"].ToString();
                    user.IdTipo = int.Parse(reader["idTipoUser"].ToString());
                }
            }
            miConexion.Close();
            return user;
        }
    }
}
