using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese estatura en metros (ej. 1.45): ");
        double estatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Ingrese edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("¿Va acompañado por un adulto? (s/n): ");
        bool acompañado = Console.ReadLine().Trim().ToLower() == "s";

        if (estatura >= 1.40 && (edad >= 12 || acompañado))
        {
            Console.WriteLine("Puede subir");
        }
        else
        {
            Console.WriteLine("No puede subir");
        }
    }
}