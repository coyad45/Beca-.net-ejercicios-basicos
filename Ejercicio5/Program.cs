using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1.5:Pedir al usuario que ingrese un número. Luego mostrar el importe con un 
            descuento del 25%*/

            //Entrada
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese un monto");
            double monto = double.Parse(Console.ReadLine());
            
            //Proceso
            double descuento = monto * 0.25;
            double sumaMonto = monto - descuento ;

            //Salida
            Console.WriteLine(" ");
            Console.WriteLine("El monto Ingresado: " + monto);
            Console.WriteLine("El descuento del 25% es: " + descuento);
            Console.WriteLine("El monto total a pagar: " + sumaMonto);

            Console.ReadKey();
        }
    }
}
