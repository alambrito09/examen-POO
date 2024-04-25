using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.interfaces_animales
{
    public class Gato : IAnimal
    {
        public void EmitirSonido()
        {
            Console.WriteLine("El gato maulla: ¡Miau miau!");
        }

        public void Moverse()
        {
            Console.WriteLine("El gato salta.");
        }
        public void esamigable()
        {
            Console.WriteLine("si solo si le das comida");
        }
    }

}
