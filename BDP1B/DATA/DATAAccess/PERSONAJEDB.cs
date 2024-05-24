using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BDP1B.DATA.DATAAccess
{
    public class PERSONAJEDB
    {
        private string connectionstring = "server localhost;Database=sys;Uid=root;Pwd=";

        public bool Probarconexion()
        {
            using (MySqlConnection conection = new MySqlConnection(connectionstring))
            {
                try
                {
                    conection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }
        public DataTable leerpersonajes()
        {
            DataTable personajes = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string sql = "select * from personajesdb";
                using (MySqlCommand comand = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comand))
                    {
                        adapter.Fill(personajes);
                    }
                }
                return personajes;
            }
        }
        public int CrearPersonaje(string nombre, string raza, int nivelPoder)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder) VALUES (@nombre, @raza, @nivelPoder)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
