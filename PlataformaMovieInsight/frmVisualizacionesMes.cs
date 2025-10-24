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
    public partial class frmVisualizacionesMes : Form
    {
        public frmVisualizacionesMes()
        {
            InitializeComponent();
        }

        //Consulta todas las visualizaciones de un mes.

        private void frmVisualizacionesMes_Load(object sender, EventArgs e)
        {
            //Se limpia Cmb de mes.
            cmbMes.Items.Clear();

            foreach (string mes in Global.Meses)
                cmbMes.Items.Add(mes);
        }
        //Boton Listar, añade en el datagridview los generos y la cantidad.
        private void btnListar_Click(object sender, EventArgs e)
        {
            int columna = cmbMes.SelectedIndex;
            int total = 0, max = int.MinValue, min = int.MaxValue;

            dgvDatosVisualMes.Rows.Clear();

            for (int i = 0; i < Global.IND; i++)
            {
                int valor = Global.Visualizaciones[i, columna];
                //Muestra todas las visualizaciones de cada género en un DataGridView.
                dgvDatosVisualMes.Rows.Add(Global.Generos[i].Nombre, valor);
                total += valor;
                if (valor > max) max = valor;
                if (valor < min) min = valor;
            }
            //Calcula y muestra total, promedio, maximo y mínimo.
            lblResultadoTotal.Text = "Total: " + total;
            lblTotalPromedio.Text = "Promedio: " + (total / Global.IND);
            lblTotalMaximo.Text = "Máximo: " + max;
            lblTotalMinimo.Text = "Mínimo: " + min;
        }
    }
}
