using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Realizar un programa que acumule (sume) valores ingresados por teclado
             * hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga).
             * Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
             */
            int num = 0,cont=-9999;
            do
            {
                Console.WriteLine("Digite un Numero: ");
                num = int.Parse(Console.ReadLine());

                cont += num;
            }while(num!=9999);
            Console.WriteLine("La Suma es: "+cont);
            if (cont == 0)
            {
                Console.WriteLine("La Suma es: 0" );
            }
            else
            {
                if (cont > 0)
                {
                    Console.WriteLine("La Suma es mayor a 0");
                }
                else
                {
                    Console.WriteLine("La Suma es menor a 0");
                }
            }
            Console.ReadKey();


        }
    }
}
