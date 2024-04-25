using eventos;

static void anuncio()
{
    MiClase miObjeto = new MiClase();
    ManejadorEvento manejador = new ManejadorEvento();

    // Suscribir el manejador al evento
    miObjeto.MiEvento += manejador.ManejarEvento;

    // Disparar el evento
    miObjeto.DispararEvento();
}
anuncio();