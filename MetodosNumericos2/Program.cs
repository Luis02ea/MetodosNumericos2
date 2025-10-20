/*
Haz un programa que pregunte al usuario 4 números que se guardarán 
en las variables con nombre: valor_1, valor_2, valor_3 y valor_4. Con estos datos realiza las siguientes operaciones matemáticas:
Suma los 4 números y guarda el resultado en la variable operación_1.
Multiplica los 4 valores dados y guarda el resultado en la variable operación_2.
Divide valor_1 entre valor_2 y suma valor_3 entre valor_4, guardando el resultado en operación _3.
Divide operación _1 entre operación _2 y guárdalo en operación_4.
Con los datos iniciales realiza las siguientes operaciones lógicas:
Verifica si valor_1 es distinto a valor_3 y guarda el resultado en la variable compara_1.
Verifica si valor_2 es igual a valor_4 y guarda el resultado en la variable compara_2.
Verifica si valor_1 es mayor que valor_3 o valor_4 y guarda el resultado en compara_3.
Verifica si valor_2 es menor que operación_3 y guarda el resultado en compara_4.
Verifica si compara_1 y compara_2 se cumplen y guarda el resultado en compara_5.
Verifica si compara_3 o compara_4 se cumplen y lo guarda en compara_6.
Imprime todas las variables “operación” y todas las variables “compara”.
Recuerda asignar a cada variable el tipo de dato adecuado para la función que va a realizar.

*/

using System;

namespace MetodosNumericos2.Actividad1
{
    public class Actividad1
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Bienvenido al programa Actividad 1");
            Console.WriteLine("Digitaliza 4 (Cuatro) Numeros para comenzar\n");

            double valor_1 = RevisarNumero("Registrar primer valor '(valor_1)': ");
            double valor_2 = RevisarNumero("Registrar segundo valor '(valor_2)': ");
            double valor_3 = RevisarNumero("Registrar tercer valor '(valor_3)': ");
            double valor_4 = RevisarNumero("Registrar cuarto valor '(valor_4)': ");

            // Operaciones aritméticas
            double operacion_1 = valor_1 + valor_2 + valor_3 + valor_4;
            double operacion_2 = valor_1 * valor_2 * valor_3 * valor_4;

            double operacion_3;
            if (valor_2 == 0 || valor_4 == 0)
            {
                operacion_3 = double.NaN; // Indica operación inválida
            }
            else
            {
                operacion_3 = (valor_1 / valor_2) + (valor_3 / valor_4);
            }

            double operacion_4;
            if (operacion_2 == 0)
            {
                operacion_4 = double.NaN;
            }
            else
            {
                operacion_4 = operacion_1 / operacion_2;
            }

            // Operaciones lógicas (evitamos comparar con NaN)
            bool compara_1 = valor_1 != valor_3;
            bool compara_2 = valor_2 == valor_4;
            bool compara_3 = (valor_1 > valor_3) || (valor_1 > valor_4);
            bool compara_4 = !double.IsNaN(operacion_3) && valor_2 < operacion_3; // Solo si operacion_3 es válida
            bool compara_5 = compara_1 && compara_2;
            bool compara_6 = compara_3 || compara_4;

            // Mostrar resultados
            Console.WriteLine("\nResultados de las operaciones matematicas:");
            Console.WriteLine($"operacion_1 (Suma): {operacion_1}");
            Console.WriteLine($"operacion_2 (Multiplicacion): {operacion_2}");
            Console.WriteLine($"operacion_3 (Divisiones y suma): {FormatoValor(operacion_3)}");
            Console.WriteLine($"operacion_4 (Division de operacion_1 / operacion_2): {FormatoValor(operacion_4)}");

            Console.WriteLine("\nResultados de las operaciones logicas:");
            Console.WriteLine($"compara_1 (valor_1 != valor_3): {compara_1}");
            Console.WriteLine($"compara_2 (valor_2 == valor_4): {compara_2}");
            Console.WriteLine($"compara_3 (valor_1 > valor_3 || valor_1 > valor_4): {compara_3}");
            Console.WriteLine($"compara_4 (valor_2 < operacion_3): {compara_4}");
            Console.WriteLine($"compara_5 (compara_1 && compara_2): {compara_5}");
            Console.WriteLine($"compara_6 (compara_3 || compara_4): {compara_6}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para leer un número válido del usuario
        public static double RevisarNumero(string mensaje)
        {
            double numero;
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                if (!double.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Error: Caracter no valido. Digitaliza un numero valido.");
                }
            } while (!double.TryParse(entrada, out numero));

            return numero;
        }

        // Método auxiliar para mostrar valores numéricos o mensajes de error
        public static string FormatoValor(double valor)
        {
            if (double.IsNaN(valor))
                return "Indefinido (división por cero)";
            if (double.IsInfinity(valor))
                return valor > 0 ? "Infinito positivo" : "Infinito negativo";
            return valor.ToString();
        }
    }
}