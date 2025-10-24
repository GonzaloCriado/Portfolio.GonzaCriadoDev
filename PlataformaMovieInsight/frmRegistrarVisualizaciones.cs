using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PlataformaMovieInsight.global;

namespace PlataformaMovieInsight
{
    public partial class frmRegistrarVisualizaciones : Form
    {
        public frmRegistrarVisualizaciones()
        {
            InitializeComponent();
        }
        //Registra la cantidad de visualizaciones por género y mes.
        //Dos ComboBox(género y mes), una TextBox para la cantidad.
        //El botón cmdCargar actualiza la matriz 'Visualizaciones' sumando la nueva cantidad.
        private void frmRegistrarVisualizaciones_Load(object sender, EventArgs e)
        {
            cmbGeneros.Items.Clear();
            cmbMes.Items.Clear();

            for (int i = 0; i < Global.IND; i++)
                cmbGeneros.Items.Add(Global.Generos[i].Nombre);
            foreach (string mes in Global.Meses)
                cmbMes.Items.Add(mes);
        }

        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            int fila = cmbGeneros.SelectedIndex;
            int columna = cmbMes.SelectedIndex;
            int cantidad = int.Parse(txtCantidadVisualizaciones.Text);

            if (fila != -1 && columna != -1)
            {
                Global.Visualizaciones[fila, columna] += cantidad;
                MessageBox.Show("Visualización registrada correctamente.");
            }
        }
    }
}
