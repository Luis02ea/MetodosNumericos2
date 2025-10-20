using System;

class Tarea5
{
    static void Main(String[] Args)
    {
        Console.Write("Ingrese el tamaño de la matriz (debe ser cuadrada): ");
        int n = int.Parse(Console.ReadLine());
        double[,] matriz = new double[n, n + 1];

        Console.WriteLine("Ingrese los valores de la matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n + 1; j++)
            {
                Console.Write($"Ingrese el valor de la posición [{i + 1}, {j + 1}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        if (SonEcuacionesDependientes(matriz, n))
        {
            Console.WriteLine("Ecuaciones dependientes");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            if (matriz[i, i] == 0)
            {
                bool cambiado = false;
                for (int k = i + 1; k < n; k++)
                {
                    if (matriz[k, i] != 0)
                    {
                        CambiarFilas(matriz, i, k, n);
                        cambiado = true;
                        break;
                    }
                }
                if (!cambiado)
                {
                    Console.WriteLine("Sistema incompatible");
                    return;
                }
            }

            double pivote = matriz[i, i];
            for (int j = 0; j < n + 1; j++)
            {
                matriz[i, j] /= pivote;
            }

            for (int k = 0; k < n; k++)
            {
                if (k != i)
                {
                    double factor = matriz[k, i];
                    for (int j = 0; j < n + 1; j++)
                    {
                        matriz[k, j] -= factor * matriz[i, j];
                    }
                }
            }
        }


        Console.WriteLine("Solución del sistema:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"x{i + 1} = {matriz[i, n]}");
        }
    }

    static bool SonEcuacionesDependientes(double[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            bool esCero = true;
            for (int j = 0; j < n + 1; j++)
            {
                if (matriz[i, j] != 0)
                {
                    esCero = false;
                    break;
                }
            }
            if (esCero) return true;
        }

        for (int i = 0; i < n; i++)
        {
            for (int k = i + 1; k < n; k++)
            {
                bool sonIguales = true;
                for (int j = 0; j < n + 1; j++)
                {
                    if (matriz[i, j] != matriz[k, j])
                    {
                        sonIguales = false;
                        break;
                    }
                }
                if (sonIguales) return true;
            }
        }

        return false;
    }


    static void CambiarFilas(double[,] matriz, int fila1, int fila2, int n)
    {
        for (int j = 0; j < n + 1; j++)
        {
            double temp = matriz[fila1, j];
            matriz[fila1, j] = matriz[fila2, j];
            matriz[fila2, j] = temp;
        }
    }
}
