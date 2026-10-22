using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese la categoría del vehículo (M, A, B, C): ");
            char cat = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            string resultado = cat switch
            {
                'M' => "Categoría M - Tarifa: $0 (exenta)",
                'A' => "Categoría A - Tarifa: $12.000",
                'B' => "Categoría B - Tarifa: $25.000",
                'C' => "Categoría C - Tarifa: $38.000",
                _ => throw new Exception("Categoría desconocida")
            };

            Console.WriteLine(resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.Message}");
        }
    }
}