using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos.Act
{
    public class Actividad4
    {

        public static void Comienzo()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Generar serie (n² - 3)/n y encontrar término mayor a 30");
                Console.WriteLine("2. Búsqueda exhaustiva para la ecuación 12 - 3x = 29");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunSeries();
                        break;
                    case "2":
                        RunEquationSolver();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void RunSeries()
        {
            int n = 1;
            while (true)
            {
                double a = (Math.Pow(n, 2) - 3) / n;
                Console.WriteLine($"Término n={n}: {a}");
                if (a > 30)
                {
                    Console.WriteLine($"El primer término mayor a 30 es en n={n}");
                    break;
                }
                n++;
            }
        }

        private static void RunEquationSolver()
        {

            double minErrorFor = double.MaxValue;
            double bestXFor = 0;
            for (double x = -7.0; x <= 0.0; x += 0.0001)
            {
                double left = 12 - 3 * x;
                double error = Math.Abs(left - 29);
                if (error < minErrorFor)
                {
                    minErrorFor = error;
                    bestXFor = x;
                }
            }
            Console.WriteLine($"x ≈ {bestXFor:F4} (error = {minErrorFor})");


            double minErrorWhile = double.MaxValue;
            double bestXWhile = 0;
            double xWhile = -7.0;
            while (xWhile <= 0.0)
            {
                double left = 12 - 3 * xWhile;
                double error = Math.Abs(left - 29);
                if (error < minErrorWhile)
                {
                    minErrorWhile = error;
                    bestXWhile = xWhile;
                }
                xWhile += 0.0001;
            }
            Console.WriteLine($"x ≈ {bestXWhile:F4} (error = {minErrorWhile})");
        }
    }
}

