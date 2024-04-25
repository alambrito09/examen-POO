using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.tipos_de_animal
{
    public class Perro : Animal
    {
        // Propiedad específica de la clase Perro
        public string Raza { get; set; }

        // Sobrescribe el método EmitirSonido para Perro
        public override void EmitirSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }
    }
}
