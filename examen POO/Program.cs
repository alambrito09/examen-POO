using examen_POO;
using static examen_POO.CARRO;



    static void carro()
    {
        // Crear una instancia de Automovil
        Automovil miAutomovil = new Automovil();
        miAutomovil.Marca = "Toyota";
        miAutomovil.Modelo = "Corolla";
        Console.WriteLine("la marca es :"+ miAutomovil.Marca); 
        Console.WriteLine("el modelo es :"+miAutomovil.Modelo);  
        miAutomovil.Arrancar(); // Salida: El automóvil está arrancando.

        // Crear una instancia de Motocicleta
        Motocicleta miMotocicleta = new Motocicleta();
        miMotocicleta.Marca = "Honda";
        miMotocicleta.Modelo = "CBR";
        Console.WriteLine("la marca es :"+ miMotocicleta.Marca);
        Console.WriteLine("el modelo es :"+miMotocicleta.Modelo);
        miMotocicleta.Arrancar(); // Salida: La motocicleta está arrancando.
    }
carro();