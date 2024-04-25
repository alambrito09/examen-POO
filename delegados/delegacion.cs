using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    // Declaración de un delegado que representa un método que toma un string como argumento y devuelve void
    public delegate void MiDelegado(string mensaje);

    // Clase que contiene métodos compatibles con el delegado
    public class EjemploDelegados
    {
        public static void Saludar(string nombre)
        {
            Console.WriteLine($"¡Hola, {nombre}!");
        }

        public static void Despedir(string nombre)
        {
            Console.WriteLine($"¡Hasta luego, {nombre}!");
        }
    }

}
