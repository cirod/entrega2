using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           /** Escribir un programa que lea n números enteros y calcule la cantidad
            * de valores mayores o iguales a 1000.
            */


            int notas, cont = 0, cont2 = 0;

            Console.WriteLine("Digite el numero de Numeros : ");
            notas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= notas; i++)
            {
                Console.WriteLine("Por Favor digite el Numero " + i + " :");
                float notatem = float.Parse(Console.ReadLine());


                if (notatem >= 1000)
                {
                    cont++;
                }
                else
                {
                    cont2++;
                }

            }

            Console.WriteLine(cont + " Numeros Mayores a 1000 y  " + cont2 + " Numeros menores a 1000: ");
            Console.ReadKey();
        }
    }
}
