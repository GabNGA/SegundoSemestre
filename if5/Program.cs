//Desarrolle un programa que calcule la cantidad total de baldes de leche producida en un día en una lechería de Estelí, utilizando como entradas el volumen promedio por vaca en litros y el número total de vacas ordeñadas, ambos proporcionados por el usuario (1 balde = 20 litros).

using System;
class Program
{
    static void Main()
    {
        const double litrosporbalde = 18.0;
        Console.WriteLine("Ingrese el volumen promedio por vaca en litros: ");
        double volumenpromedio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el número total de vacas ordeñadas: ");
        double numerodevacas = Convert.ToDouble(Console.ReadLine());
        double totaldeleche = volumenpromedio * numerodevacas;
        double baldesdeleche = totaldeleche / litrosporbalde;
        Console.WriteLine($"La cantidad total de baldes de leche producida en un día es: {baldesdeleche} baldes");
        


    }
    
}