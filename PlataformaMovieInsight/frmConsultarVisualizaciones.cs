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
    public partial class frmConsultarVisualizaciones : Form
    {
        public frmConsultarVisualizaciones()
        {
            InitializeComponent();
        }

        private void frmConsultarVisualizaciones_Load(object sender, EventArgs e)
        {
            cmbGeneros.Items.Clear();
            cmbMes.Items.Clear();

            for (int i = 0; i < Global.IND; i++)
                cmbGeneros.Items.Add(Global.Generos[i].Nombre);

            foreach (string mes in Global.Meses)
                cmbMes.Items.Add(mes);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int fila = cmbGeneros.SelectedIndex;
            int columna = cmbMes.SelectedIndex;

            if (fila != -1 && columna != -1)
            {
                lblCantVisualizaciones.Text = Global.Visualizaciones[fila, columna].ToString();
            }
        }
    }
}
