using indexador;

static void colete()
{
    Coleccion miColeccion = new Coleccion();

    // Asignar valores a través del indexador
    miColeccion[0] = "Elemento 1";
    miColeccion[1] = "Elemento 2";
    miColeccion[2] = "Elemento 3";

    // Acceder a los elementos a través del indexador
    Console.WriteLine($"Elemento en la posición 0: {miColeccion[0]}");
    Console.WriteLine($"Elemento en la posición 1: {miColeccion[1]}");
    Console.WriteLine($"Elemento en la posición 2: {miColeccion[2]}");

    // Intentar acceder a un índice fuera de los límites de la colección
    try
    {
        Console.WriteLine(miColeccion[5]); // Esto lanzará una excepción IndexOutOfRangeException
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
colete();