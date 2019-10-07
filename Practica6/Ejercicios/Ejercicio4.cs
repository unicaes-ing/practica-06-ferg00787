using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6.Ejercicios
{
    class Ejercicio4
    {
        static long Binario(long num)
        {
            if (num < 2)
            {
                return num;
            }

            else
            {
                return num % 2 + (10 * Binario(num / 2));
            }


        }


        static void Main(string[] args)
        {
            long num;

            Console.WriteLine("Ingrese el numero que desea convertir a binario: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("El numero convertido a Binario es igual a: " + (Binario(num)));
            Console.ReadKey();

        }


    }
}
