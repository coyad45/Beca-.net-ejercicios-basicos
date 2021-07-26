using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1.4:Pedir al usuario que ingrese un número.Luego mostrar el importe con un aumento
            del 10 %*/

            //Entrada
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese un monto");

            //Proceso
            double monto = double.Parse(Console.ReadLine());
            double aumento = monto * 0.1;
            double sumaMonto = monto * 1.10;

            //Salida
            Console.WriteLine(" ");
            Console.WriteLine("El monto Ingresado: " + monto);
            Console.WriteLine("El aumento del 10% es: " + aumento);
            Console.WriteLine("El monto total es: " + sumaMonto);

            Console.ReadKey();

        }
    }
}
