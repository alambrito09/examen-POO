using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.tipos_de_animal
{
    // Clase derivada o subclase
    public class Gato : Animal
    {
        // Propiedad específica de la clase Gato
        public bool EsCazador { get; set; }

        // Sobrescribe el método EmitirSonido para Gato
        public override void EmitirSonido()
        {
            Console.WriteLine("El gato maulla: ¡Miau miau!");
        }
    }

}
