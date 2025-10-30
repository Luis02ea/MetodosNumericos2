/*
PARTE 1

Método de interpolación Newton:

1. Encuentra una ecuación para modelar los siguientes datos:

2. Encuentra el valor de la ecuación cuando X es igual a 3.5

Entregable:

Excel con el proceso para crear la matriz.
Reporte que incluya:
Código.
Ecuación final.
Captura de la solución, que incluya la matriz resultante, la ecuación obtenida y el resultado de la ecuación cuando x es igual 3.5
 

PARTE 2: 

Método de interpolación:

1. Encuentra una ecuación para modelar los siguientes datos:



2. Encuentra el valor de la ecuación cuando X es igual a 6.574

*/



double[] x = { 1, 2, 3, 4, 5, 6 };
double[] y = { -3, -165, -783, -1851, -1851, 4167 };
double xBusqueda = 3.5, yBusqueda;
int ecuaciones = x.Length; //cantidad de ecuaciones
int columnas = ecuaciones + 1; //cantidad d eincognitas
double pivote, factor;
double[,] matriz = new double[ecuaciones, columnas];


//Llenar parte de cuadrada de la matriz
for (int r = 0; r < ecuaciones; r++) //Renglones
{
    for (int c = 0; c < columnas - 1; c++) //Columnas
    {
        //Programar funcion
        matriz[r, c] = Math.Pow(x[r], c);
    }
}

//llenar la ultima columna de la matriz
for (int r = 0; r < ecuaciones; r++) //Renglones
{
    matriz[r, columnas - 1] = y[r];
}

//imprimir matriz
for (int r = 0; r < ecuaciones; r++)

{
    for (int c = 0; c < columnas; c++)
    {
        Console.Write(matriz[r, c] + "\t");
    }
    Console.WriteLine();
}


//aplicar gauss

///imprimir matriz

//código para imprimir la ecuación

//encuentres el valor de la función en xbusqueda

