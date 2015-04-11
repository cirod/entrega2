using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de números por teclado, 
             * obtener su promedio. Finalizar la carga de valores cuando se cargue 
             * el valor 0.
             */
            float num,cont=0;
            do
            {
                Console.WriteLine("Digite un numero: ");
                num = float.Parse(Console.ReadLine());
                cont += num;
            }while(num!=0);

            Console.WriteLine("La suma es:  "+cont);
            Console.ReadKey();

        }
    }
}
