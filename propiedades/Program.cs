using propiedades;

static void personita()
{
    // Creamos una instancia de Persona utilizando el constructor
    Persona persona1 = new Persona("Alan", 22);

    // Accedemos y modificamos las propiedades de la persona
    Console.WriteLine($"Nombre de la persona: {persona1.Nombre}"); // Acceso a la propiedad Nombre
    Console.WriteLine($"Edad de la persona: {persona1.Edad}"); // Acceso a la propiedad Edad

    // Modificamos la edad utilizando el setter de la propiedad Edad
    persona1.Edad = 22;

    // Mostramos la información actualizada de la persona
    persona1.MostrarInformacion();
}
personita();