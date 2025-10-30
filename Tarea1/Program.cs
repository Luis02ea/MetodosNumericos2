/*
Crea un programa que pregunte al usuario tres números que se guardarán en las variables con nombre:
número_1, número_2 y número_3.
Con estos datos realiza las siguientes operaciones matemáticas:
Suma número_1 y número_2 y réstale número_3, guarda el resultado en la variable Opera_1.
Multiplica los tres valores dados y guarda el resultado en la variable Opera_2.
Obtén el residuo de la división del número_2 entre el número_3 y guárdalo en Opera_3.
Con los datos iniciales harás las siguientes operaciones lógicas:
Verifica si número_1 es igual a número_3 y guarda el resultado en la variable contraste_1.
Verifica si número_1 es mayor que número_2 y mayor que número_3, guarda el resultado en contraste_2.
Verifica si contraste_1 y contraste_2 se cumplen y guarda el resultado en contraste_3.
Imprime todas las variables “Opera” y todas las variables “contraste”.
Recuerda asignar a cada variable el tipo de dato adecuado para la función que va a realizar.
 
 
 */

using System; 
using System.Collections.Generic;
using System.Globalization;

namespace Tarea1

{
    internal class Tarea1
    {
        private static void Main()
        {
            Console.WriteLine("Bienvendio a este programa de la tarea 1");

            double numero_1 = LeerNumero("numero_1");
            double numero_2 = LeerNumero("numero_2");
            double numero_3 = LeerNumero("numero_3");

            double Opera_1 = numero_1 + numero_2 - numero_3;
            double Opera_2 = numero_1 * numero_2 * numero_3;
            double? Opera_3 = null;
            if (numero_3 !=0)
            {
                Opera_3 = numero_2 % numero_3;
            }

            bool contraste_1 = numero_1 == numero_3;
            bool contraste_2 = numero_1 > numero_2 && numero_1 > numero_3;
            bool contraste_3 = contraste_1 && contraste_2;

        }
        private static double LeerNumero(string mensaje)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double numero))
                    return numero;
                Console.WriteLine("Dato no valido, favor de ingresar un dato valido");
            }

        }
        
    }

    

}





