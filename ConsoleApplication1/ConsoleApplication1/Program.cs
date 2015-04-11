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
            /**
             * Escribir un programa que lea 10 notas de alumnos y nos informe cuántos 
             * tienen notas mayores o iguales a 7 y cuántos menores.
                Para resolver este problema se requieren tres contadores

              */


            int notas, cont=0,cont2=0 ;

            Console.WriteLine("Digite el numero de Notas: ");
            notas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= notas; i++)
            {
                Console.WriteLine("Por Favor digite la Nota "+i+" :");
                float notatem = float.Parse(Console.ReadLine());


                if(notatem>=7) 
                {
                    cont++;
                }
                else
                {
                    cont2++;
                }

            }

               Console.WriteLine(cont+" Estudiantes tuvieron notas mayores a 7 y "+cont2+" Tuvieron nota inferior a 7");
            Console.ReadKey();
        }
    }
}
