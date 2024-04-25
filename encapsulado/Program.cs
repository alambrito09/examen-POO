using encapsulado;

static void promerica()
{
    // Crear una instancia de CuentaBancaria
    CuentaBancaria cuenta = new CuentaBancaria("Alan Villaseñor", 3500);

    // Acceder a las propiedades y métodos públicos
    Console.WriteLine($"Titular de la cuenta: {cuenta.Titular}");
    Console.WriteLine($"Saldo actual: ${cuenta.Saldo}");

    cuenta.Depositar(500);
    Console.WriteLine($"Saldo después del depósito: ${cuenta.Saldo}");

    cuenta.Retirar(200);
    Console.WriteLine($"Saldo después del retiro: ${cuenta.Saldo}");

    // Intentar asignar un titular nulo (esto provocará el mensaje de error)
    cuenta.Titular = null;
}
promerica();