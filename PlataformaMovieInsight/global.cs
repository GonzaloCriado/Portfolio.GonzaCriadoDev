using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaMovieInsight
{
    // Esta estructura define un género con sus tres propiedades.
    internal class global
    {
        public struct RegistroGenero
        {
            public int Codigo;         // Código identificador del género.
            public string Nombre;      // Nombre del género.
            public string Descripcion; // Descripción del género.
        }



        // Clase estática para contener los datos globales usados en todos los formularios.
        public static class Global
        {
            // Vector para guardar hasta 30 géneros registrados.
            public static RegistroGenero[] Generos = new RegistroGenero[30];
            public static int IND = 0; // Índice para saber cuántos géneros hay cargados

            // Vector con los nombres de los meses, usados para la matriz de visualizaciones.
            public static string[] Meses = {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
        "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
    };
            // Matriz donde cada fila representa un género y cada columna un mes. 
            // Visualizaciones[i,j] es la cantidad de visualizaciones del género i en el mes j.
            public static int[,] Visualizaciones = new int[30, 12];
        }
    }
}
