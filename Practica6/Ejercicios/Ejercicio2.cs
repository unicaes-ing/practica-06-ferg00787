using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6.Ejercicios
{
    class Ejercicio2
    {
        public static string Dibujar(decimal figura)
        {
            string ach = "";
            for (int i = 1; i <= figura; i++)
            {
                ach = ach + "*";
            }

            return ach;
        }

        public static string Dibujar(decimal figura, string elegirFigura)
        {
            string ach = elegirFigura;
            for (int i = 1; i <= figura; i++)
            {
                ach = ach + elegirFigura;

            }

            return ach;
        }



        static void Main(string[] args)
        {

            Console.Write("Ingrese el ancho de la figura: ");
            Console.WriteLine("----------------------------");
            decimal anchMain = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el alto de de la Figura: ");
            Console.WriteLine("----------------------------");
            decimal altMain = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese la figura que desea");
            string f = Console.ReadLine();
            Console.WriteLine("Ingrese las coordenadas para mostrar su figura en ellas (Ingrese 0 para dejar las coordenadas de predeterminadas): ");
            Console.Write("X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X == 0 && Y == 0)
            {

                if (f == "")
                {
                    Console.WriteLine(" ---Su Figura-----");
                    for (int cuentaLineas = 1; cuentaLineas <= altMain; cuentaLineas++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Dibujar(anchMain));
                    }
                    Console.ReadKey();
                }
                else
                {

                    Console.WriteLine("---Su Figura-----");
                    for (int cuentaLineas = 1; cuentaLineas <= altMain; cuentaLineas++)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Dibujar(anchMain, f));
                    }
                    Console.ReadKey();
                }

            }

            if (X > 0 && Y > 0)
            {
                if (f == "")
                {
                    Console.WriteLine("---Su Figura-----");
                    for (int cuentaLineas = 1; cuentaLineas <= altMain; cuentaLineas++)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Dibujar(anchMain));
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("---Su Figura-----");
                    for (int cuentaLineas = 1; cuentaLineas <= altMain; cuentaLineas++)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Dibujar(anchMain, f));
                    }
                    Console.ReadKey();
                }
            }
        }

    }
}
