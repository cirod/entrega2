using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVector1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Crear un vector de n elementos de tipo entero (n se ingresa por teclado)
             * Mostrar cuantos elementos son superiores a 100 (emplear el foreach para 
             * recorrer el vector).
            */
            int[] vector;
            int numero,cont=0;
            Console.WriteLine("Digite el numero de elementos en el vector. ");
            numero = int.Parse(Console.ReadLine());
            vector = new int[numero];
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite un numero: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

                foreach (int var in vector)
                {
                    if (var > 100)
                        cont++;
                }
            Console.WriteLine("Hay " + cont + " numeros mayores a 100.");
            Console.ReadKey();


        }
    }
}
