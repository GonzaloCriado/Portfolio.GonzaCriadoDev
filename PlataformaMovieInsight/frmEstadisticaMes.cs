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
    public partial class frmEstadisticaMes : Form
    {
        public frmEstadisticaMes()
        {
            InitializeComponent();
        }

        //Muestra una grilla con estadísticas para cada mes.
        //Columnas: Mes, Total, Promedio, Género más visto, Género menos visto.
        //El botón cmdListar recorre columnas de la matriz y calcula estadísticas.

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEstadisticasMes.Rows.Clear();

            for (int j = 0; j < 12; j++)
            {
                int total = 0, max = int.MinValue, min = int.MaxValue;
                int generoMax = -1, generoMin = -1;

                for (int i = 0; i < Global.IND; i++)
                {
                    int valor = Global.Visualizaciones[i, j];
                    total += valor;
                    if (valor > max) { max = valor; generoMax = i; }
                    if (valor < min) { min = valor; generoMin = i; }
                }

                int promedio = total / Global.IND;

                dgvEstadisticasMes.Rows.Add(


                    Global.Meses[j],
                    total,
                    promedio,
                    Global.Generos[generoMax].Nombre,
                    Global.Generos[generoMin].Nombre
                );
            }
        }
    }
}
