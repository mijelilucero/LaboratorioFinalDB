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
        Consola cons = new Consola();
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
            conexionCatalogoConsolas.CrearConsola(cons);
        }

        private void buttonCargarRegistros_Click(object sender, EventArgs e)
        {
            todos_losRegistros = conexionCatalogoConsolas.ObtenerRegistros();
            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
                cursor1.actual = 0;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        private void MostrarRegistro()
        {
            if (cursor1.actual >= 0 && cursor1.actual < cursor1.totalRegistros)
            {
                Consola c = todos_losRegistros[cursor1.actual];
                textBoxID.Text = c.Id.ToString();
                textBoxNombre.Text = c.NombreConsola.ToString();
                comboBoxCompania.Text = c.Compania.ToString();
                textBoxAnio_lanzamiento.Text = c.AnioLanzamiento.ToString();
                textBoxGeneracion.Text = c.Generacion.ToString();


                //incrementar el cursor y validar que no se pase del total de registros
                cursor1.actual++;
                if (cursor1.actual >= cursor1.totalRegistros)
                {
                    cursor1.actual = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }









    }
}
