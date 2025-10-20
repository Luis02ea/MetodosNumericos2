using System;
using System.Linq;

namespace MetodosNumericos2.Actividad2
{

    public class Actividad2
    {
       
        public static void Main(String[]args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("Bienvenido a la Actividad 2");
                Console.WriteLine("Selecciona un programa:");
                Console.WriteLine("1: Indicador de sueño");
                Console.WriteLine("2: Multiplicar números del 1 al 10");
                Console.WriteLine("3: Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.\n");
                    continue; 
                }

                switch (opcion)
                {
                    case 1:
                        IndicadorDeSueno();
                        break;
                    case 2:
                        MultiplicarNumeros();
                        break;
                    case 3:
                        salir = true;
                        Console.WriteLine("Gracias por usar el programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.\n");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\n¿Desea regresar al menú principal? (si/no)");
                    string respuesta = Console.ReadLine()?.Trim().ToLower() ?? "";
               
                    if (respuesta != "si" && respuesta != "s")
                    {
                        salir = true;
                        Console.WriteLine("Gracias por usar el programa.");
                    }
                    Console.WriteLine(); 
                }

            } while (!salir);
        }

        private static void IndicadorDeSueno()
        {
            int horaDormir = -1;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("\nIndique la hora en la que se va a dormir (0 a 23): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int hora) && hora >= 0 && hora <= 23)
                {
                    horaDormir = hora;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Hora inválida. Por favor, ingrese un número entre 0 y 23.");
                }
            }

            int horaDespertar = (horaDormir + 8) % 24;
            string horaRecomendada = $"{horaDespertar:D2}:00";

            if (horaDormir >= 21 && horaDormir <= 22)
            {
                Console.WriteLine($"Usted duerme a muy buena hora, felicidades. Hora recomendada de despertar: {horaRecomendada}");
            }
            else if (horaDormir == 23 || horaDormir <= 1)
            {
                Console.WriteLine($"Duerme usted un poco tarde, trate de descansar más. Hora recomendada de despertar: {horaRecomendada}");
            }
            else if (horaDormir >= 2 && horaDormir <= 4)
            {
                Console.WriteLine($"Usted duerme muy tarde, eso no es bueno para la salud. Hora recomendada de despertar: {horaRecomendada}");
            }
            else if (horaDormir >= 5 && horaDormir <= 10)
            {
                Console.WriteLine($"Supongo que duerme a estas horas porque tiene un trabajo nocturno. Hora recomendada de despertar: {horaRecomendada}");
            }
            else if (horaDormir >= 11 && horaDormir <= 18)
            {
                Console.WriteLine($"Usted tiene un horario de sueño muy extraño. Hora recomendada de despertar: {horaRecomendada}");
            }
            else 
            {
                Console.WriteLine($"Usted duerme muy temprano. Hora recomendada de despertar: {horaRecomendada}");
            }
        }

        private static void MultiplicarNumeros()
        {
            long resultado = 1;

            for (int i = 1; i <= 10; i++)
            {
                resultado *= i;
            }

            Console.WriteLine($"\nEl resultado de multiplicar los números del 1 al 10 es: {resultado:N0}");
        }
    }
}
