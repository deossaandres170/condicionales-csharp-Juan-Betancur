using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese nota 1 (0-100): ");
        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Ingrese nota 2 (0-100): ");
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Ingrese nota 3 (0-100): ");
        double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double promedio = (n1 + n2 + n3) / 3.0;

        char letra = promedio >= 90 ? 'A' :
                     promedio >= 80 ? 'B' :
                     promedio >= 70 ? 'C' :
                     promedio >= 60 ? 'D' : 'F';

        string retroalimentacion = letra switch
        {
            'A' => "Desempeño excelente",
            'B' or 'C' => "Buen desempeño, sigue así",
            'D' => "Aprobado, refuerza los temas",
            'F' => "Debe presentar plan de mejoramiento",
            _ => ""
        };

        string estado = promedio >= 60 ? "Aprobado" : "Reprobado";

        Console.WriteLine($"Promedio: {promedio.ToString("0.0", CultureInfo.InvariantCulture)} | Letra: {letra} | {retroalimentacion} | {estado}");

        if (Math.Abs(promedio - 100.0) < 0.001)
        {
            Console.WriteLine("¡Mención de honor!");
        }
    }
}