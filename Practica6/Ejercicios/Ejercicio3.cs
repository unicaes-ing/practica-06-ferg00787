using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6.Ejercicios
{
    class Ejercicio3
    {
        static int Potencia(int num, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }

            else
            {
                return num * Potencia(num, exp - 1);

            }
        }


        static void Main(string[] args)
        {
            int num, exp;
            Console.WriteLine("Ingrese la base: ");
            Console.WriteLine("----------------");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el exponente: ");
            Console.WriteLine("--------------------");
            exp = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("La base elevado al exponente es: " + Potencia(num, exp));

            Console.ReadKey();
        }

    }
}
