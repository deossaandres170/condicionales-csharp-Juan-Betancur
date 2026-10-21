using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la nota final (0 a 5): ");
        double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";

        Console.WriteLine($"Nota: {nota.ToString("0.0", CultureInfo.InvariantCulture)} - {estado}");
    }
}