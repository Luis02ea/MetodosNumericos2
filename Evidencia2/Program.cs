/*
 
**Evidencia 2 – Métodos Numéricos**

1. En la presente evidencia, se realizará un programa que incluya cuatro métodos numéricos
complementarios para analizar dos series de datos. Los datos corresponden a la estatura de 
dos recién nacidos (Aníbal y María).
2. Con los datos que se dan, encuentran dos ecuaciones que modelen el comportamiento del crecimiento
de los recién nacidos a lo largo del primer año, utilizando el método de mínimos cuadrados que
se ajusten a la curva.



Ecuaciones a modelar

Aníbal: y(t) = x*1 ln (t)  + x*2

María: y(t) = x*1 * cos(t/8)+x * 2 * et / 10

1.Escribe las ecuaciones modeladas con las constantes obtenidas.

**Aníbal**:

**María:**

1.Gráficas de los datos discretos versus la ecuación modelada.
    1. Gráfica Anibal
    2. Gráfica María

**3. Con base en las ecuaciones de cada uno de los recién nacidos, utiliza un método visto en clase para el sistema de ecuaciones no lineales que indique en qué momento los dos bebés tendrán la misma estatura, por primera vez.**

1. **Gráfica de las dos ecuaciones en un mismo plano, para comprobar la primera intersección.**
2. **Estatura y mes obtenido:**

1. Halla un método que encuentre raíces de ecuaciones no lineales para saber cuándo la estatura será exactamente 60 cm en cada uno de los bebés. Utilizar un método distinto para cada bebe.
    1. Método utilizado para Anibal:
    2. Mes en el que la estatura de Aníbal es de 60 cms:
    3. Método utilizado para María:
    4. Mes en el que la estatura de María es de 60 cms:

> Documentación:
> 
1. Código c#:
2. Captura de pantalla de tus resultados con el siguiente formato:

> Constantes de la ecuación de Aníbal:
> 
> 
> x1=_______
> 
> x2=_______
> 
> ecuación: ____________ *
> 
> Constantes de la ecuación de María:
> 
> x1=_______
> 
> X2=_______
> 
> ecuación: ____________ *
> 
> Los bebés tendrán la misma estatura de _____ a los _____ meses
> 
> La estatura de Aníbal será de 60 centímetros a los _____ meses
> 
> La estatura de María será de 60 centímetros a los _____ meses
>

 */




public class Matris
{
    public string Nombre { get; set; }
    public string Mes { get; set; }

    public double Medicion { get; set; }

    public string Metrica { get; set; }


    public override string ToString()
    {
        return $"{Nombre,-15} | {Mes,-2} | {Medicion,9} | {Metrica}";
    }
}
    
    public class Evidencia2
{
    public static void Main(string[] args)

    {
        Matris[] matris = new Matris[]
    {
                new Matris {Nombre = "Anibal" , Mes = "Enero", Medicion = 50 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Febrero", Medicion = 55 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Marzo", Medicion = 60 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Abril", Medicion = 61 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Mayo", Medicion = 65 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Junio", Medicion = 67 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Julio", Medicion = 69 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Agosto", Medicion = 70 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Septiembre", Medicion = 72 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Octubre", Medicion = 73 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Noviembre", Medicion = 74 , Metrica= "cm"  },
                new Matris {Nombre = "Anibal" ,  Mes = "Diciembre", Medicion = 76 , Metrica= "cm"  },
                new Matris {Nombre = "Maria"  ,  Mes = "Enero", Medicion = 49, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Febrero", Medicion = 57, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Marzo", Medicion = 59, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Abril", Medicion = 61, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Mayo", Medicion = 63, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Junio", Medicion = 65, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Julio", Medicion = 67, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Agosto", Medicion = 69, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Septiembre", Medicion = 70, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Octubre", Medicion = 71, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Noviembre", Medicion = 72, Metrica = "cm" },
                new Matris {Nombre = "Maria"  ,  Mes = "Diciembre", Medicion = 74, Metrica = "cm" }




    };
      


        double[] t_meses = Enumerable.Range(1, 12).Select(i => (double)i).ToArray();
        double[] y_anibal_Datos = matris.Where(m => m.Nombre == "Anibal").Select(m => m.Medicion).ToArray();
        double[] y_maria_Datos = matris.Where(m => m.Nombre == "Maria").Select(m => m.Medicion).ToArray();


    }


    //Nueva Funcion 

    //(yAnibal) (t) - (yMaria) (t) = 0 

    // Esta funcion sera utlizada para determinar el punto en el que ambos bebes tendran la misma estatura
    //Formula encontrada para  tn+1 = tn - f(tn) / f'(tn)



    /*Mnadar a imprimir los datos */
    public static void ImprimirProductos(Matris[] matris)
    {
        Console.WriteLine($"{"Mes",-15} | {"Medicion",9} | Metrica");
        Console.WriteLine(new string('-', 45));
        foreach (Matris p in matris)
        {
            Console.WriteLine(p);
        }
    }

    /*Ordenar al momento de imprimir los datos */


    public static void OrdenamientoDeDatos(Matris[] matris)
    {
        int n = matris.Length;
    }


}


