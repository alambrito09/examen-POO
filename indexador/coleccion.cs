using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Coleccion
    {
        private string[] elementos = new string[5]; // Arreglo interno para almacenar los elementos

        // Indexador que permite acceder a los elementos de la colección como si fuera un array
        public string this[int index]
        {
            get
            {
                // Verificar que el índice esté dentro de los límites del arreglo
                if (index >= 0 && index < elementos.Length)
                {
                    return elementos[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fuera de los límites de la colección.");
                }
            }
            set
            {
                // Verificar que el índice esté dentro de los límites del arreglo
                if (index >= 0 && index < elementos.Length)
                {
                    elementos[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fuera de los límites de la colección.");
                }
            }
        }
    }
}
