using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el día de la semana: ");
        string dia = Console.ReadLine().Trim().ToLower();

        Console.Write("¿Es estudiante? (s/n): ");
        bool esEstudiante = Console.ReadLine().Trim().ToLower() == "s";

        int precio = 0;

        if (dia == "martes")
        {
            precio = 7000;
        }
        else if (dia == "sábado" || dia == "domingo")
        {
            precio = 15000;
        }
        else
        {
            precio = esEstudiante ? 9000 : 12000;
        }

        Console.WriteLine($"El precio de la boleta es: ${precio:N0}");
    }
}