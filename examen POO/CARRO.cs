using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_POO
{
    public abstract class CARRO
    {
        // Propiedades comunes a todos los vehículos
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // Método abstracto que debe ser implementado por las clases derivadas
        public abstract void Arrancar();
    }

    // Clase derivada que representa un automóvil
    public class Automovil : CARRO
    {
        // Implementación del método Arrancar específica para Automovil
        public override void Arrancar()
        {
            Console.WriteLine("El automóvil está arrancando.");
        }
    }

    // Clase derivada que representa una motocicleta
    public class Motocicleta : CARRO
    {
        // Implementación del método Arrancar específica para Motocicleta
        public override void Arrancar()
        {
            Console.WriteLine("La motocicleta está arrancando.");
        }
    }
}

