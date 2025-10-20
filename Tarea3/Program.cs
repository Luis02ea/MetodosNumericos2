//Aqui empieza
using System;
using System.Collections.Generic;

namespace MetodosNumericos
{


    class Tarea3
    {
        static void Main()
        {
            Console.WriteLine("¿Cuántos estados de la república mexicana conoces o has visitado en tu vida?");
            int cantidadEstados = int.Parse(Console.ReadLine());


            List<List<string>> lugaresVisitados = new List<List<string>>();
            List<List<string>> anecdotas = new List<List<string>>();

            for (int i = 0; i < cantidadEstados; i++)
            {
                Console.WriteLine($"Ingresa el nombre del estado {i + 1}:");
                string estado = Console.ReadLine();

                Console.WriteLine($"¿Cuántos lugares has visitado en {estado}?");
                int cantidadLugares = int.Parse(Console.ReadLine());


                List<string> lugares = new List<string>();
                List<string> anecdotasEstado = new List<string>();

                for (int j = 0; j < cantidadLugares; j++)
                {
                    Console.WriteLine($"Ingresa el nombre del lugar {j + 1} en {estado}:");
                    string lugar = Console.ReadLine();
                    lugares.Add(lugar);

                    Console.WriteLine($"Cuenta una anécdota que recuerdes de {lugar}:");
                    string anecdota = Console.ReadLine();
                    anecdotasEstado.Add(anecdota);
                }

                lugaresVisitados.Add(lugares);
                anecdotas.Add(anecdotasEstado);
            }

            Console.WriteLine("\nResumen de tus visitas y anécdotas:");
            for (int i = 0; i < cantidadEstados; i++)
            {
                Console.WriteLine($"\nEn el estado {i + 1}:");
                for (int j = 0; j < lugaresVisitados[i].Count; j++)
                {
                    Console.WriteLine($"- Visitaste {lugaresVisitados[i][j]} y recuerdas: \"{anecdotas[i][j]}\"");
                }
            }
        }
    }

}

//Aqui termina