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
    public partial class frmVisualizacionesGenero : Form
    {
        public frmVisualizacionesGenero()
        {
            InitializeComponent();
        }

        //Consulta todas las visualizaciones mes a mes de un género.
        private void frmVisualizacionesGenero_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();

            //ComboBox de género.
            for (int i = 0; i < Global.IND; i++)
                cmbGenero.Items.Add(Global.Generos[i].Nombre);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int fila = cmbGenero.SelectedIndex;
            int total = 0, max = int.MinValue, min = int.MaxValue;

            dgvDatosVisualGenero.Rows.Clear();

            for (int j = 0; j < 12; j++)
            {
                int valor = Global.Visualizaciones[fila, j];
                dgvDatosVisualGenero.Rows.Add(Global.Meses[j], valor);
                total += valor;
                if (valor > max) max = valor;
                if (valor < min) min = valor;
            }
            //Calcula y muestra total, promedio, máximo y mínimo.

            lblResultadoTotal.Text = "Total: " + total;
            lblTotalPromedio.Text = "Promedio: " + (total / 12);
            lblTotalMaximo.Text = "Máximo: " + max;
            lblTotalMinimo.Text = "Mínimo: " + min;
        }
    }
}
