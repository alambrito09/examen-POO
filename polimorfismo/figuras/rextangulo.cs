using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.figuras
{
    public class Rectangulo : Figura
    {
        private double baseRect;
        private double altura;

        // Constructor que recibe la base y la altura del rectángulo
        public Rectangulo(double b, double h)
        {
            baseRect = b;
            altura = h;
        }

        // Sobrescribe el método CalcularArea para el rectángulo
        public override void CalcularArea()
        {
            double area = baseRect * altura;
            Console.WriteLine($"El área del rectángulo es: {area}");
        }
    }
}
