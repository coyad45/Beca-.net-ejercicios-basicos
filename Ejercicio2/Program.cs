using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1.2:Pedir al usuario que ingrese su nombre y
            edad y mostrar “Usted es [nombre] y tiene[edad] años”*/

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Usted es: {0}" + " y tiene {1} años",nombre,edad);

            Console.ReadKey();

        }
    }
}
