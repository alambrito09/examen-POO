using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propiedades
{
    // Clase que representa una persona con propiedades para nombre y edad
    public class Persona
    {
        // Propiedad para el nombre de la persona
        public string Nombre { get; set; }

        // Propiedad para la edad de la persona
        private int edad;

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0) // Validamos que la edad sea positiva
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("Error: La edad debe ser un número positivo.");
                }
            }
        }

        // Constructor de la clase Persona
        public Persona(string nombre, int edad)
        {
            Nombre = nombre; // Asignamos el nombre usando la propiedad automáticamente generada
            Edad = edad; // Asignamos la edad usando el setter de la propiedad
        }

        // Método para mostrar información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
