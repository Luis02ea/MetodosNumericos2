using System;

public class M
{
    public static void Main(string[] a)
    {
        bool b = true;

        while (b)
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1. Sumar renglones de una matriz 2x3");
            Console.WriteLine("2. Buscar nombre en una lista");
            Console.WriteLine("3. Salir");
            Console.Write("Opcion: ");

            string c = Console.ReadLine();

            switch (c)
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    b = false;
                    Console.WriteLine("Fin del programa.");
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Intenta otra vez.");
                    break;
            }

            if (b)
            {
                Console.WriteLine("\nPresiona Enter para volver al menu...");
                Console.ReadLine();
            }
        }
    }

    public static void P1()
    {
        Console.Clear();

        int[,] a = new int[2, 3];

        Console.WriteLine("Programa 1: Suma de renglones de una matriz 2x3");
        Console.WriteLine("Introduce los 6 numeros de la matriz.");

        for (int b = 0; b < 2; b++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write($"Valor para renglon {b + 1}, columna {c + 1}: ");
                a[b, c] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int d = a[0, 0] + a[0, 1] + a[0, 2];
        int e = a[1, 0] + a[1, 1] + a[1, 2];

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Renglon 1: " + d);
        Console.WriteLine("Renglon 2: " + e);
    }

    public static void P2()
    {
        Console.Clear();

        string[] a = { "Juan", "Gabriela", "Franco", "Mara", "Violeta" };

        Console.WriteLine("Programa 2: Busqueda de nombres");

        Console.Write("Escribe un nombre para buscar: ");
        string b = Console.ReadLine();

        bool c = false;
        int d = -1;

        for (int e = 0; e < a.Length; e++)
        {
            if (a[e].Equals(b, StringComparison.OrdinalIgnoreCase))
            {
                c = true;
                d = e;
                break;
            }
        }

        if (c)
        {
            Console.WriteLine("Nombre encontrado en la posicion: " + d);
        }
        else
        {
            Console.WriteLine("Nombre no encontrado en la lista.");
        }
    }
}
