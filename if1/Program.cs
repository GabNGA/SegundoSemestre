

using System;

class Program
{
    static void Main()
    {
        const double ancho = 5.0;
        const double varaspormanzanas = 1428.57;
        Console.WriteLine("ingrese la longitud del terreno en varas: ");
        double longitud = Convert.ToDouble(Console.ReadLine());
        double area = ancho * longitud;
        double manzanas = area / varaspormanzanas;
        Console.WriteLine($"El area del terreno es: {area}  varas cuadradas");
        Console.WriteLine($"El area del terreno en manzanas es: {manzanas}");

    }
}
   