using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace MetodosNumericosEvidencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            int e;
            bool v = true;
            do
            {


                Console.WriteLine("Bienvenidos ala Evidencia 1 ");
                Console.WriteLine("Para inicializar selecciona una opcion: ");
                Console.WriteLine("Opcion 1");
                Console.Write(" Este programa pedirá al usuario que ingrese el ");
                Console.Write("tamaño de la matriz, sus valores y luego aplicará la Conjetura de Collatz para cada ");
                Console.WriteLine("valor ingresado, contando los pasos hasta que cada número llegue a 1.");
                Console.WriteLine("Opcion 2");
                Console.WriteLine("dado un número múltiplo de 3, se aplicarán las operaciones de suma de cubos de sus cifras hasta que se llegue al número 153.");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        ConjeturaCollatz();
                        break;

                    case 2:
                        NumeroEspecial153();
                        break;

                    default:
                        Console.WriteLine("Dato erroneo intentelo de nuevo : ");
                        Console.WriteLine("Precione '0' si desea salir ");
                        Console.WriteLine("Preciona '1' si deseas continuar");
                        int t = int.Parse(Console.ReadLine());

                        if (t == 0)
                        {
                            v = false;
                        }
                        else
                        {
                            v = true;
                        }
                        break;
                }
            } while (v);


        }

        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduce el tamaño de la matriz (máx 16 elementos): ");
            int tamaño = int.Parse(Console.ReadLine());

            if (tamaño > 16)
            {
                Console.WriteLine("La matriz no puede tener más de 16 elementos.");
                return;
            }

            int[,] matriz = new int[tamaño, tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    int valor;
                    do
                    {
                        Console.WriteLine($"Introduce un valor para la posición [{i},{j}] entre 200 y 600:");
                        valor = int.Parse(Console.ReadLine());
                    }
                    while (valor < 200 || valor > 600);

                    matriz[i, j] = valor;
                }
            }

            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    int pasos = CalcularCollatz(matriz[i, j]);
                    Console.WriteLine($"El número {matriz[i, j]} llega a 1 en {pasos} pasos.");
                }
            }
        }

        static int CalcularCollatz(int numero)
        {
            int pasos = 0;
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero /= 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                pasos++;
            }
            return pasos;
        }

        static void NumeroEspecial153()
        {
            Console.WriteLine("\nIntroduce un número natural mayor a cero y múltiplo de tres: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0 || numero % 3 != 0)
            {
                Console.WriteLine("El número debe ser mayor que cero y múltiplo de tres.");
                return;
            }

            List<int> numerosPasados = new List<int>();
            numerosPasados.Add(numero);

            while (numero != 153)
            {
                numero = SumarCubosDeCifras(numero);
                numerosPasados.Add(numero);
            }

            Console.WriteLine("Secuencia de números para llegar a 153:");
            foreach (int num in numerosPasados)
            {
                Console.WriteLine(num);
            }
        }

        static int SumarCubosDeCifras(int numero)
        {
            int suma = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                suma += digito * digito * digito;
                numero /= 10;
            }
            return suma;
        }
    }

}