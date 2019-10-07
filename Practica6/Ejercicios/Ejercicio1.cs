using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Ejercicio1
    {
        static string Tabla(int num)
        {
            string TablaFinal = "";
            int num1 = 0;
            int num2 = num;
            int final = 0;
            for (int i = 1; i <= 10; i++)
            {
                num1 = num1 + 1;
                final = num1 * num2;
                Console.WriteLine(" {0} * {1} = {2}", num2, num1, final);
            }
            return TablaFinal;
        }

        static string Tabla(int num, int color)
        {
            string TablaFinal = "";
            int num1 = 0;
            int num2 = num;
            int final = 0;

            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            for (int i = 1; i <= 10; i++)
            {
                num1 = num1 + 1;
                final = num1 * num2;
                Console.WriteLine(" {0} * {1} = {2}", num2, num1, final);
            }
            return TablaFinal;
        }

        static void Main(string[] args)
        {
            int numero;
            int color;
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Ingrese el numero de la tabla a generar: ");
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("------------------------------------------");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Ingrese el color de la tabla a generar: ");
            Console.WriteLine("[1]. Rojo");
            Console.WriteLine("[2]. Azul");
            Console.WriteLine("[3]. Amarillo");
            Console.WriteLine("[4]. Verde");
            Console.WriteLine("[5]. Predeterminado");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("------------------------------------------");
            color = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(Tabla(numero, color));
            Console.ReadKey();

        }
    }
}
        
    
