using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos.Act
{
    public class Actividad3
    {

        public static void comienzo()
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuPrincipal();
                int opcion = LeerEnteroSeguro("Selecciona una opción: ", 1, 3);

                switch (opcion)
                {
                    case 1:
                        Opcion1();
                        break;
                    case 2:
                        Opcion2();
                        break;
                    case 3:
                        continuar = false;
                        Console.WriteLine("Gracias por usar el programa!");
                        break;

                }
                if (continuar && opcion != 3)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private static void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO A LA ACTIVIDAD 3");
            Console.WriteLine();
            Console.WriteLine("[1] Crea tu Propia Matriz");
            Console.WriteLine("[2] Promedio Semestral");
            Console.WriteLine("[3] Salir");
            Console.WriteLine();
        }

        public static void Opcion1()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("CREA TU PROPIA MATRIZ");
                Console.WriteLine();

                int filas = LeerEnteroSeguro("Ingresa el número de filas (1-10): ", 1, 10);
                int columnas = LeerEnteroSeguro("Ingresa el número de columnas (1-10): ", 1, 10);

                int[,] matriz = new int[filas, columnas];

                Console.WriteLine("Ingresa los valores para una matriz de " + filas + "x" + columnas + ":");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matriz[i, j] = LeerEnteroSeguro(
                            "Posición [" + (i + 1) + "," + (j + 1) + "]: ",
                            int.MinValue,
                            int.MaxValue
                        );
                    }
                }

                Console.WriteLine("Matriz original:");
                ImprimirMatriz(matriz, filas, columnas);

                int multiplicador = LeerEnteroSeguro(
                    "Ingresa el multiplicador para la matriz: ",
                    int.MinValue,
                    int.MaxValue
                );

                int[,] matrizMultiplicada = MultiplicarMatriz(matriz, filas, columnas, multiplicador);

                Console.WriteLine("Matriz multiplicada por " + multiplicador + ":");
                ImprimirMatriz(matrizMultiplicada, filas, columnas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
        }

        public static void Opcion2()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("PROMEDIO DEL SEMESTRE");
                Console.WriteLine();

                int numMaterias = LeerEnteroSeguro("Ingresa el número de materias (1-15): ", 1, 15);

                double[] calificaciones = new double[numMaterias];
                string[] nombresMaterias = new string[numMaterias];

                Console.WriteLine();
                for (int i = 0; i < numMaterias; i++)
                {
                    Console.Write("Nombre de la materia " + (i + 1) + ": ");
                    nombresMaterias[i] = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(nombresMaterias[i]))
                    {
                        nombresMaterias[i] = "Materia " + (i + 1);
                    }

                    calificaciones[i] = LeerDoubleSeguro(
                        "Calificación (0-100): ",
                        0,
                        100
                    );
                    Console.WriteLine();
                }

                double promedio = calificaciones.Average();
                double maxima = calificaciones.Max();
                double minima = calificaciones.Min();

                Console.WriteLine("RESULTADOS");
                Console.WriteLine();

                for (int i = 0; i < numMaterias; i++)
                {
                    Console.WriteLine(nombresMaterias[i] + " " + calificaciones[i].ToString("F2"));
                }

                Console.WriteLine();
                Console.WriteLine("Promedio: " + promedio.ToString("F2"));
                Console.WriteLine("Calificación más alta: " + maxima.ToString("F2"));
                Console.WriteLine("Calificación más baja: " + minima.ToString("F2"));
                Console.WriteLine("Estado: " + (promedio >= 60 ? "APROBADO" : "REPROBADO"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
        }

        private static int LeerEnteroSeguro(string mensaje, int min, int max)
        {
            int resultado;
            bool valido;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                valido = int.TryParse(entrada, out resultado);

                if (!valido)
                {
                    Console.WriteLine("Error: Debes ingresar un número entero válido.");
                }
                else if (resultado < min || resultado > max)
                {
                    Console.WriteLine("Error: El número debe estar entre " + min + " y " + max + ".");
                    valido = false;
                }
            } while (!valido);

            return resultado;
        }

        private static double LeerDoubleSeguro(string mensaje, double min, double max)
        {
            double resultado;
            bool valido;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                valido = double.TryParse(entrada, out resultado);

                if (!valido)
                {
                    Console.WriteLine("Error: Debes ingresar un número válido.");
                }
                else if (resultado < min || resultado > max)
                {
                    Console.WriteLine("Error: El número debe estar entre " + min + " y " + max + ".");
                    valido = false;
                }
            } while (!valido);

            return resultado;
        }

        private static void ImprimirMatriz(int[,] matriz, int filas, int columnas)
        {
            int anchoMaximo = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int ancho = matriz[i, j].ToString().Length;
                    if (ancho > anchoMaximo)
                        anchoMaximo = ancho;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(anchoMaximo + 2));
                }
                Console.WriteLine(" |");
            }
        }

        private static int[,] MultiplicarMatriz(int[,] matriz, int filas, int columnas, int multiplicador)
        {
            int[,] resultado = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = matriz[i, j] * multiplicador;
                }
            }

            return resultado;

        }
    }

}


