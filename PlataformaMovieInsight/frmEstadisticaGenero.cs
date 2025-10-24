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
    public partial class frmEstadisticaGenero : Form
    {
        public frmEstadisticaGenero()
        {
            InitializeComponent();
        }
        //Muestra estadísticas de cada género en fila.
        //Columnas: Género, Total, Promedio, Mes más visto, Mes menos visto.
        //El botón cmdListar recorre filas de la matriz y calcula estadísticas.

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEstadisticasGenero.Rows.Clear();
            for (int i = 0; i < Global.IND; i++)
            {
                int total = 0, max = int.MinValue, min = int.MaxValue;
                int mesMax = -1, mesMin = -1;

                for (int j = 0; j < 12; j++)
                {
                    int valor = Global.Visualizaciones[i, j];
                    total += valor;
                    if (valor > max) { max = valor; mesMax = j; }
                    if (valor < min) { min = valor; mesMin = j; }
                }

                int promedio = total / 12;
                dgvEstadisticasGenero.Rows.Add(
                    Global.Generos[i].Nombre,
                    total,
                    promedio,
                    Global.Meses[mesMax],
                    Global.Meses[mesMin]
                );
            }
        }
    }
}
