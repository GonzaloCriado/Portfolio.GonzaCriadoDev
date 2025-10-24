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
    public partial class frmConsultaGenero : Form
    {
        public frmConsultaGenero()
        {
            InitializeComponent();
        }

        //Consulta individual de género.
        //ComboBox cargado con los nombres.
        //Al seleccionar un nombre y presionar cmdConsultar, muestra el código y descripción.

        private void frmConsultaGenero_Load(object sender, EventArgs e)
        {
            //Se limpia el cmbGeneros para actualizar luego si hay algun genero nuevo
            cmbListadoGeneros.Items.Clear();
            for (int i = 0; i < Global.IND; i++)
            {
                //Se carga el cmbListadoGeneros con los generos cargados automatica y manualmente.
                cmbListadoGeneros.Items.Add(Global.Generos[i].Nombre);
            }

        }

        private void btnConsultarGenero_Click(object sender, EventArgs e)
        {
            int index = cmbListadoGeneros.SelectedIndex;
            if (index != -1)
            {
                lblCodigo.Text = Global.Generos[index].Codigo.ToString();
                lblDescripcion.Text = Global.Generos[index].Descripcion;
            }
        }
    }
}
