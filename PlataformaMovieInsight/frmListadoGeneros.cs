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
    public partial class frmListadoGeneros : Form
    {
        public frmListadoGeneros()
        {
            InitializeComponent();
        }

     
        //Lista todos los géneros en un DataGridView.
        //El botón btnListar recorre el vector y agrega los registros al DataGridView.
        //Muestra cuántos géneros hay con una Label (lblCantidadGenero) contador.
        private void btnListar_Click(object sender, EventArgs e)
        {
            //Limpia la grilla cada vez que se presiona btnListar
            dgvListadoGeneros.Rows.Clear();

            //Es una condicion for.
            for (int i = 0; i < Global.IND; i++)
            {
                //Agrega los generos con sus codigo nommbre y descripcion dentro de la grilla en cada columna.
                dgvListadoGeneros.Rows.Add(
                    Global.Generos[i].Codigo,
                    Global.Generos[i].Nombre,
                    Global.Generos[i].Descripcion
                );
            }
            //Actualiza el contador de los generos y lo muestra por el lblCantidadGenero
            lblCantidadGenero.Text = "Total de géneros: " + Global.IND;
        }
    }
}
