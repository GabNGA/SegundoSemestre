//Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada, donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, asumiendo una distancia fija de 40 kilómetros.
using System;

class Program
{  
    static void Main()
    {  
        const double distancia = 40.0;
        Console.WriteLine("Ingrese la velocidad promedio en km/h: ");
        double velocidad = Convert.ToDouble(Console.ReadLine());
        double tiempo = distancia / velocidad;
        Console.WriteLine($"El tiempo total del viaje es: {tiempo} horas");
    }
} 

