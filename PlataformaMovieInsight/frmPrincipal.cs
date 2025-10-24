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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------
        //Aqui comienza la seccion "Sistema"

        //Muestra información del alumno (nombre, DNI, carrera y materia).
        //No tiene lógica compleja, solo se cargan los datos en Labels en el Load del formulario.
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe v = new frmAcercaDe();//Redirrecciona al formulario
            v.ShowDialog();//Muestra el formulario
        }


        //Genera 10 géneros automáticamente con nombres, descripciones y visualizaciones aleatorias
        //Actualiza Global.IND y muestra mensaje de éxito
        private void cargaAutomáticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guarda en un vector llamado "nombre" los nombres de los generos
            string[] nombres = {
        "Acción", "Comedia", "Drama", "Ciencia Ficción", "Romántica",
        "Terror", "Fantasía", "Misterio", "Aventura", "Animación"
    };

            //Guarda en un vector llamado "descripciones" las descripciones de las peliculas tambien en un string con el mismo genero, muestra el mismo lugar 
            string[] descripciones = {
        "Películas llenas de emocionantes escenas de persecuciones, combates y situaciones de riesgo.",
        "Películas diseñadas para hacer reír al público con situaciones cómicas y humor.",
        "Historias centradas en el desarrollo emocional de los personajes, a menudo explorando situaciones intensas.",
        "Películas que presentan elementos de ciencia avanzada, tecnología futurista y conceptos imaginativos.",
        "Historias centradas en relaciones amorosas y emociones románticas.",
        "Películas destinadas a asustar o provocar miedo en la audiencia.",
        "Historias que incluyen elementos mágicos, criaturas extraordinarias y mundos imaginarios.",
        "Películas que involucran la resolución de un enigma o crimen.",
        "Narrativas emocionantes que siguen a los personajes en viajes y desafíos.",
        "Películas que utilizan técnicas de animación para contar historias, generalmente dirigidas a un público más joven."
    };

            //Genera un random llamado "rand" donde carga los datos automaticamente.
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Global.Generos[i].Codigo = i + 1;
                Global.Generos[i].Nombre = nombres[i];
                Global.Generos[i].Descripcion = descripciones[i];
                for (int j = 0; j < 12; j++)
                {
                    Global.Visualizaciones[i, j] = rand.Next(0, 101);
                }
            }
            Global.IND = 10;
            MessageBox.Show("Datos cargados correctamente.");
        }

        //Cierra la plataforma
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        //----------------------------------------------------------------------------------------------------------
        //Aqui comienza la seccion "Generos"



        private void agregaNuevoGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoGenero v = new frmAgregarNuevoGenero();
            v.ShowDialog();
        }

        private void listadoGeneralGenerosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmListadoGeneros v = new frmListadoGeneros();
            v.ShowDialog();
        }

        private void consultaDeDatosDeUnGéneroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaGenero v = new frmConsultaGenero();
            v.ShowDialog();
        }

        //----------------------------------------------------------------------------------------------------------
        //Aqui comienza la seccion "Visualizaciones"

        private void registrarVisualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarVisualizaciones v = new frmRegistrarVisualizaciones();
            v.ShowDialog();
        }

        private void consultaDeVisualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVisualizaciones v = new frmConsultarVisualizaciones();
            v.ShowDialog();
        }

        private void visualizacionesDeUnMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionesMes v = new frmVisualizacionesMes();
            v.ShowDialog();
        }

        private void visualizacionesDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionesGenero v = new frmVisualizacionesGenero();
            v.ShowDialog();
        }

        private void estadísticaDeVisualizacionesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaMes v = new frmEstadisticaMes();
            v.ShowDialog();
        }

        private void estadísticaDeVisualizacionesPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaGenero v = new frmEstadisticaGenero();
            v.ShowDialog();
        }

    }
    }


