using System;

namespace MetodosNumericosTarea2
{
    class Tarea2
    {
        public static void Main(String[] Args)
        {
            double i;
            float a;


            Console.WriteLine("Bienvenido a este programa");
            Console.WriteLine("Instrucciones:");
            Console.WriteLine("Digitaliza un numero, ya sea un numero entero o un numero decimal.");
            Console.WriteLine("El programa te dira si es una fraccion o un entero y posteriormente");
            Console.WriteLine("Si digitalizaste un numero entero el programa te dira si es par o impar.");
            Console.WriteLine("Digitaliza un numero puede decir un decimal o numero entero:");
            a = float.Parse(Console.ReadLine());

            if (a % 1 == 0)
            {
                Console.WriteLine("El numero proporcionado es un numero entero " + a);

                if (a % 2 == 0)
                {
                    Console.WriteLine("El numero que proporcionaste es un numero par: " + a);
                }
                else
                {
                    Console.WriteLine("El numero que proporcionaste es un numero impar: " + a);
                }
            }
            else
            {
                Console.WriteLine("El numero proporcionado es un numero decimal: " + a);
            }

            float b = (float)Math.Sqrt(a);
            Console.WriteLine("La raiz cuadrada del numero proporcionado es: " + b);


            for (i = 0; i <= a; i += 0.01)
            {

                if (Math.Abs(i * i - a) < 0.01)
                {
                    Console.WriteLine("La raiz cuadrada aproximada es: " + i);

                    break;
                }
            }

        }
    }
}