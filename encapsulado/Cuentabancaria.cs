using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulado
{
    public class CuentaBancaria
    {
        private string titular;
        private double saldo;

        // Propiedad para acceder al titular de la cuenta
        public string Titular
        {
            get { return titular; }
            set
            {
                // Validar que el valor no sea nulo o vacío antes de asignarlo
                if (!string.IsNullOrEmpty(value))
                {
                    titular = value;
                }
                else
                {
                    Console.WriteLine("Error: El titular no puede ser nulo o vacío.");
                }
            }
        }

        // Propiedad para acceder al saldo de la cuenta
        public double Saldo
        {
            get { return saldo; }
            private set { saldo = value; } // El saldo solo puede ser modificado internamente
        }

        // Constructor para inicializar la cuenta bancaria
        public CuentaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        // Método para depositar dinero en la cuenta
        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"Depósito de ${monto} realizado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: El monto a depositar debe ser mayor que cero.");
            }
        }

        // Método para retirar dinero de la cuenta
        public void Retirar(double monto)
        {
            if (monto > 0 && monto <= Saldo)
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro de ${monto} realizado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: Monto inválido para retirar o saldo insuficiente.");
            }
        }
    }
}
