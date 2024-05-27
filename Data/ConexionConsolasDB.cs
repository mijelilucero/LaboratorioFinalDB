using LaboratorioFinalDB.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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



        //CREATE: Insertar un registro con una clase model
        public bool CrearConsola(Consola cons)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                try
                {
                    string consulta = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombreConsola, @compania, @anioLanzamiento, @generacion)";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombreConsola", cons.NombreConsola);
                        cmd.Parameters.AddWithValue("@compania", cons.Compania);
                        cmd.Parameters.AddWithValue("@anioLanzamiento", cons.AnioLanzamiento);
                        cmd.Parameters.AddWithValue("@generacion", cons.Generacion);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //READ: Seleccionar todos los registros usando List
        public List<Consola> ObtenerTodosLosRegistros()
        {
            List<Consola> consolas = new List<Consola>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM catalogo_consolas";
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
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return consolas;
        }


        //Buscar un registro por ID
        public DataRow BuscarRegistroporID(int id)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "SELECT * FROM catalogo_consolas WHERE id_consola = @ID";
                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    cmd.Parameters.AddWithValue("@ID", id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    connection.Open();
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return data.Rows[0];
        }



        //UPDATE: Actualizar un registro
        public bool Actualizar(Consola cons)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)){
                try
                {
                    string consulta = "UPDATE catalogo_consolas SET nombre_consola = @Nombre, compania = @Compania, anio_lanzamiento = @AnioLanzamiento, generacion = @Generacion WHERE id_consola = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", cons.Id);
                        cmd.Parameters.AddWithValue("@Nombre", cons.NombreConsola);
                        cmd.Parameters.AddWithValue("@Compania", cons.Compania);
                        cmd.Parameters.AddWithValue("@AnioLanzamiento", cons.AnioLanzamiento);
                        cmd.Parameters.AddWithValue("@Generacion", cons.Generacion);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //DELETE: Eliminar un registro
        public bool Eliminar(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "DELETE FROM catalogo_consolas WHERE id_consola = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //FILTRAR REGISTROS

        //Por Nintendo
        public List<Consola> ObtenerRegistrosNintendo()
        {
            List<Consola> consolas = new List<Consola>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM catalogo_consolas WHERE compania='Nintendo'";
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
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return consolas;
        }



        //Por Sega
        public List<Consola> ObtenerRegistrosSega()
        {
            List<Consola> consolas = new List<Consola>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM catalogo_consolas WHERE compania='Sega'";
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
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return consolas;
        }



        //Por Sega
        public List<Consola> ObtenerRegistrosSony()
        {
            List<Consola> consolas = new List<Consola>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM catalogo_consolas WHERE compania='Sony'";
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
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return consolas;
        }










    }
}
