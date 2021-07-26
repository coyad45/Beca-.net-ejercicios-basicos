using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1.3:Pedir al usuario que ingrese dos números, sumarlos y mostrar el resultado.*/
            
            //Entrada
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese un numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int numero2 = int.Parse(Console.ReadLine());

            //Proceso
            int sumaN = numero1 + numero2;
           
            //Salida
            Console.WriteLine("El total de la suma de los numeros es:" + sumaN);

            Console.ReadKey();
        }
    }
}
