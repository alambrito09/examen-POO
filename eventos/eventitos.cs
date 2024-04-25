using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventos
{
    // Declaración de un delegado para el evento
    public delegate void MiEventHandler();

    // Clase que contiene un evento
    public class MiClase
    {
        // Declaración del evento utilizando el delegado MiEventHandler
        public event MiEventHandler MiEvento;

        // Método que dispara el evento
        public void DispararEvento()
        {
            Console.WriteLine("Evento disparado.");
            OnMiEvento(); // Llamar al método protegido para invocar el evento
        }

        // Método protegido para invocar el evento de forma segura
        protected virtual void OnMiEvento()
        {
            MiEvento?.Invoke(); // Invocar el evento si hay suscriptores
        }
    }
    // Clase que maneja el evento
    public class ManejadorEvento
    {
        // Método que maneja el evento
        public void ManejarEvento()
        {
            Console.WriteLine("Evento manejado por el manejador de eventos.");
        }
    }
}
