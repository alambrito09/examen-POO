using polimorfismo.figuras;
using polimorfismo;

static void figuritas()
{
    // Crear instancias de las clases derivadas
    Figura figura1 = new Circulo(10);
    Figura figura2 = new Rectangulo(4, 10);

    // Llamar al método CalcularArea de forma polimórfica
    figura1.CalcularArea(); // Salida: El área del círculo 
    figura2.CalcularArea(); // Salida: El área del rectángulo 
}
figuritas();