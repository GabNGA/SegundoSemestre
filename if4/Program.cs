using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Ingrese el largo del tanque: ");
        double largo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ancho del tanque: ");
        double ancho = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del tanque: ");
        double altura = double.Parse(Console.ReadLine());
        double volumen = (altura * ancho * largo) / 1000;
        Console.WriteLine($"El volumen del tanque es: {volumen} metros cúbicos");   
        
    }
}
