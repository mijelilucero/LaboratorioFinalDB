using LaboratorioFinalDB.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioFinalDB.Data
{
    internal class ConexionConsolasDB
    {
        string connectionString = "server=localhost;database=LaboratorioFinal;user=root;password=Mijlu30";

        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        //Seleccionar todo usando List
        public List<Consola> ObtenerRegistros()
        {
            List<Consola> consolas = new List<Consola>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Usuarios";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Consola consola = new Consola
                        (
                            id: reader.GetInt32("id_consola"),
                            nombreConsola: reader.GetString("nombre_consola"),
                            compania: reader.GetString("compania"),
                            anioLanzamiento: reader.GetInt32("anio_lanzamiento"),
                            generacion: reader.GetInt32("generacion")
                        );

                        consolas.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return consolas;
        }
















        //CREATE: Insertar un registro con modelos
        public void CrearConsola(Consola cons)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                try
                {
                    string consulta = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombreConsola, @compania, @anioLanzamiento, @generacion)";
                    using (MySqlCommand command = new MySqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@nombreConsola", cons.NombreConsola);
                        command.Parameters.AddWithValue("@compania", cons.Compania);
                        command.Parameters.AddWithValue("@anioLanzamiento", cons.AnioLanzamiento);
                        command.Parameters.AddWithValue("@generacion", cons.Generacion);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


       









    }
}
