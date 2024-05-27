using LaboratorioFinalDB.Data;
using LaboratorioFinalDB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LaboratorioFinalDB
{
    public partial class Form1 : Form
    {

        ConexionConsolasDB conexionCatalogoConsolas = new ConexionConsolasDB();
        List<Consola> todos_losRegistros;
        CursorLista cursor1 = new CursorLista();

        // Lista de compañias
        private string[] companiasConsolas = {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony",
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conexionCatalogoConsolas.ProbarConexion())
            {
                MessageBox.Show("La conexion con la base de datos fue exitosa.");
            }
            else
            {
                MessageBox.Show("Algo fallo al intentar hacer la conexion con la base de datos.");
            }

            comboBoxCompania.Items.AddRange(companiasConsolas);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Consola consCrear = new Consola();

            consCrear.NombreConsola = textBoxNombre.Text;
            consCrear.Compania = comboBoxCompania.Text;
            consCrear.AnioLanzamiento = Int32.Parse(textBoxAnio_lanzamiento.Text);
            consCrear.Generacion = Int32.Parse(textBoxGeneracion.Text);

            if (conexionCatalogoConsolas.CrearConsola(consCrear))
            {
                MessageBox.Show("El registro fue creado exitosamente.");
                dataGridViewConsolas.DataSource = conexionCatalogoConsolas.ObtenerTodosLosRegistros();
                ActualizarTotalRegistros();
            }
            else
            {
                MessageBox.Show("El registro no fue creado dentro de la base de datos.");
            }
        }


        private void buttonCargarRegistros_Click(object sender, EventArgs e)
        {
            todos_losRegistros = conexionCatalogoConsolas.ObtenerTodosLosRegistros();
            dataGridViewConsolas.DataSource = todos_losRegistros;

            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }

        private void buttonBuscarPorID_Click(object sender, EventArgs e)
        {
            int id_buscar = Int32.Parse(textBoxID.Text);
            DataRow registro_encontrado = conexionCatalogoConsolas.BuscarRegistroporID(id_buscar);

            if (registro_encontrado != null)
            {
                textBoxNombre.Text = registro_encontrado["nombre_consola"].ToString();
                comboBoxCompania.Text = registro_encontrado["compania"].ToString();
                textBoxAnio_lanzamiento.Text = registro_encontrado["anio_lanzamiento"].ToString();
                textBoxGeneracion.Text = registro_encontrado["generacion"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontro registro con este id.");
            }

            cursor1.actual = id_buscar - 1;
        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Consola consActualizar = new Consola();
            
            consActualizar.Id = Convert.ToInt32(textBoxID.Text);
            consActualizar.NombreConsola = textBoxNombre.Text;
            consActualizar.Compania = comboBoxCompania.Text;
            consActualizar.AnioLanzamiento = Int32.Parse(textBoxAnio_lanzamiento.Text);
            consActualizar.Generacion = Int32.Parse(textBoxGeneracion.Text);

            DialogResult resultado = MessageBox.Show("Estas seguro de que deseas actualizar este registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (conexionCatalogoConsolas.Actualizar(consActualizar))
                {
                    MessageBox.Show("El registro fue actualizado exitosamente.");
                    dataGridViewConsolas.DataSource = conexionCatalogoConsolas.ObtenerTodosLosRegistros();
                    ActualizarTotalRegistros();
                }
                else
                {
                    MessageBox.Show("El registro no fue actualizado dentro de la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Modificaciones no realizadas.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);
            
            DialogResult resultado = MessageBox.Show("Estas seguro de que deseas eliminar permanentemente este registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (conexionCatalogoConsolas.Eliminar(id))
                {
                    MessageBox.Show("El registro fue eliminado exitosamente.");
                    dataGridViewConsolas.DataSource = conexionCatalogoConsolas.ObtenerTodosLosRegistros();
                    ActualizarTotalRegistros();
                }
                else
                {
                    MessageBox.Show("El registro no fue eliminado dentro de la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Modificaciones no realizadas.");
            }
        }


        //NAVEGACION DE REGISTROS
        private void MostrarRegistroActual()
        {
            if (cursor1.actual >= 0 && cursor1.actual < cursor1.totalRegistros)
            {
                Consola c = todos_losRegistros[cursor1.actual];
                textBoxID.Text = c.Id.ToString();
                textBoxNombre.Text = c.NombreConsola;
                comboBoxCompania.Text = c.Compania;
                textBoxAnio_lanzamiento.Text = c.AnioLanzamiento.ToString();
                textBoxGeneracion.Text = c.Generacion.ToString();
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
          
            if (cursor1.actual < cursor1.totalRegistros - 1) // Verificar antes de incrementar
            {
                cursor1.actual++;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (cursor1.actual > 0) // Verificar antes de decrementar
            {
                cursor1.actual--;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }
        
        public void ActualizarTotalRegistros()
        {
            todos_losRegistros = conexionCatalogoConsolas.ObtenerTodosLosRegistros();

            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }

        private void buttonFiltrar_porNintendo_Click(object sender, EventArgs e)
        {
            List<Consola> registrosNintendo;

            registrosNintendo = conexionCatalogoConsolas.ObtenerRegistrosNintendo();
            dataGridViewConsolas.DataSource = registrosNintendo;
        }

        private void buttonFiltrar_porSega_Click(object sender, EventArgs e)
        {
            List<Consola> registrosSega;

            registrosSega = conexionCatalogoConsolas.ObtenerRegistrosSega();
            dataGridViewConsolas.DataSource = registrosSega;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Consola> registrosSony;

            registrosSony = conexionCatalogoConsolas.ObtenerRegistrosSony();
            dataGridViewConsolas.DataSource = registrosSony;
        }
    }
}
