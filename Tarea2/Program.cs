using System;

namespace MetodosNumericosTarea2
{
    class Tarea2
    {
        public static void Main(string[] a)
        {
            bool b = false;

            while (!b)
            {
                Console.Clear();
                Console.WriteLine("     Metodos Numericos");
                Console.WriteLine("1. Determinar tipo de número y raiz cuadrada");
                Console.WriteLine("2. Dividir número entre 2 hasta llegar a 1");
                Console.WriteLine("3. Sumar números pares entre 4 y 20");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string c = Console.ReadLine();
                Console.Clear();

                switch (c)
                {
                    case "1":
                        P1();
                        break;
                    case "2":
                        P2();
                        break;
                    case "3":
                        P3();
                        break;
                    case "4":
                        b = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                if (!b)
                {
                    Console.WriteLine("\nPresiona una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        public static void P1()
        {
            double a;
            float b;

            Console.WriteLine("   PROGRAMA 1 - Tipo de número");
            Console.WriteLine("Digitaliza un número (entero o decimal):");
            b = float.Parse(Console.ReadLine());

            if (b % 1 == 0)
            {
                Console.WriteLine("El número proporcionado es un número entero: " + b);

                if (b % 2 == 0)
                    Console.WriteLine("El número es par.");
                else
                    Console.WriteLine("El número es impar.");
            }
            else
            {
                Console.WriteLine("El número proporcionado es decimal: " + b);
            }

            float c = (float)Math.Sqrt(b);
            Console.WriteLine("\nLa raíz cuadrada del número es: " + c);

            for (a = 0; a <= b; a += 0.01)
            {
                if (Math.Abs(a * a - b) < 0.01)
                {
                    Console.WriteLine("Raíz cuadrada aproximada: " + a);
                    break;
                }
            }
        }

        public static void P2()
        {
            Console.WriteLine("   PROGRAMA 2 - División entre 2");
            Console.Write("Ingresa un número entero: ");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNúmeros por los que pasa la operación:");

            Console.Write(a);

            while (a > 1)
            {
                if (a % 2 == 0)
                    a = a / 2;
                else
                    a = a + 1;

                Console.Write(", " + a);
            }
        }

        public static void P3()
        {
            Console.WriteLine("   PROGRAMA 3 - Suma de pares 4 a 20");

            int a = 0;

            for (int b = 4; b <= 20; b++)
            {
                if (b % 2 == 0)
                {
                    a += b;
                }
            }

            Console.WriteLine("La suma de los números pares entre 4 y 20 es: " + a);
        }
    }
}
