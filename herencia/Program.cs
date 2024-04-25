using herencia.tipos_de_animal;


    static void animalitos()
    {
        // Crear una instancia de Perro
        Perro miPerro = new Perro();
        miPerro.Nombre = "manchas";
        miPerro.Edad = 3;
        miPerro.Raza = "Labrador";
        Console.WriteLine("edad es : "+miPerro.Edad);
        Console.WriteLine("la raza es :"+ miPerro.Raza);
        
        miPerro.EmitirSonido(); // Salida: El perro ladra: ¡Guau guau!

        // Crear una instancia de Gato
        Gato miGato = new Gato();
        miGato.Nombre = "michije";
        miGato.Edad = 2;
        miGato.EsCazador = true;
        Console.WriteLine("es cazadro :"+miGato.EsCazador);
        Console.WriteLine("la edad es :"+miGato.Edad);
        Console.WriteLine("el nombre es :"+miGato.Nombre);
        miGato.EmitirSonido(); // Salida: El gato maulla: ¡Miau miau!
    }
animalitos();