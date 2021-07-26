using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.1: Pedir al usuario su nombre y mostrarlo por consola

            Console.WriteLine("Indique su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("El nombre del usuario es: " + nombre);

            Console.ReadKey();
        }
    }
}
