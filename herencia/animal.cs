using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    // Clase base o superclase
    public class Animal
    {
        // Propiedades comunes a todos los animales
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Método virtual que puede ser sobrescrito por las clases derivadas
        public virtual void EmitirSonido()
        {
            Console.WriteLine("El animal emite un sonido.");
        }
    }
}
