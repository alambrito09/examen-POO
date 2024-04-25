using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.figuras
{
    public class Circulo : Figura
    {
        private double radio;

        // Constructor que recibe el radio del círculo
        public Circulo(double r)
        {
            radio = r;
        }

        // Sobrescribe el método CalcularArea para el círculo
        public override void CalcularArea()
        {
            double area = Math.PI * radio * radio;
            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}
