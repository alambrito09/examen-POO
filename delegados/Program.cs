using delegados;

static void dell()
{
    // Crear una instancia del delegado y asociarle un método
    MiDelegado delegado = EjemploDelegados.Saludar;

    // Invocar el delegado utilizando la sintaxis de punto de exclamación (!)
    delegado!("Juan");

    // Cambiar la referencia del delegado a otro método
    delegado = EjemploDelegados.Despedir;

    // Invocar el delegado con el nuevo método asociado
    delegado!("Juan");
}
dell();