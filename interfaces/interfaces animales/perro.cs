using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.interfaces_animales
{
    public class Perro : IAnimal
    {
        public void EmitirSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }

        public void Moverse()
        {
            Console.WriteLine("El perro corre.");
        }
        public void esamigable()
        {
            Console.WriteLine("es el mejor amigo del hombre ");
        }
    }
}
