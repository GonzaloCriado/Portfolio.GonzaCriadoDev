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
    public partial class frmAgregarNuevoGenero : Form
    {
        public frmAgregarNuevoGenero()
        {
            InitializeComponent();
        }

        //Reutilizacion de procedimiento.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        //Reutilizacion de procedimiento.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        //Reutilizacion de procedimiento.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        //Un procedimiento privado para validar los campos y que no te deje cargar el genero si algun txt esta vacio.
        private void ValidarCampos()
        {
            btnCargar.Enabled = txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "";
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Una condicion de la mano de la clase global en donde si global.IND es menor a 10 se agrega el genero,
            //si sobrepasa 10 salta el mensaje de capacidad maxima alcanza.
            if (Global.IND < 30)
            {
                // Agrega un nuevo género a la estructura Global
                Global.Generos[Global.IND].Codigo = int.Parse(txtCodigo.Text);
                Global.Generos[Global.IND].Nombre = txtNombre.Text;
                Global.Generos[Global.IND].Descripcion = txtDescripcion.Text;
                Global.IND++; // Aumenta el contador

                MessageBox.Show("Género agregado correctamente.");

                // Limpia los campos de entrada
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                btnCargar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Capacidad máxima de 30 géneros alcanzada.");
            }
            
        }
    }
}
