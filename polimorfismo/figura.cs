using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class Figura
    {
        // Método virtual que puede ser sobrescrito por las clases derivadas
        public virtual void CalcularArea()
        {
            Console.WriteLine("Calculando el área de la figura base.");
        }
    }
}
