using interfaces.interfaces_animales;
using interfaces;
static void interfacesanimalito()
{
    // Crear instancias de las clases que implementan la interfaz IAnimal
    IAnimal animal1 = new Perro();
    IAnimal animal2 = new Gato();

    // Llamar a métodos a través de la interfaz
    animal1.EmitirSonido(); // Salida: El perro ladra: ¡Guau guau!
    animal1.Moverse(); // Salida: El perro corre.
    animal1.esamigable();

    animal2.EmitirSonido(); // Salida: El gato maulla: ¡Miau miau!
    animal2.Moverse(); // Salida: El gato salta.
    animal2.esamigable();
}
interfacesanimalito();