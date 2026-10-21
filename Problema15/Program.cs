using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el peso en kg: ");
        double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Ingrese la estatura en metros: ");
        double estatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double imc = peso / (estatura * estatura);
        string categoria = imc < 18.5 ? "Bajo peso" :
                           imc < 25.0 ? "Peso normal" :
                           imc < 30.0 ? "Sobrepeso" : "Obesidad";

        Console.WriteLine($"IMC: {imc.ToString("0.1", CultureInfo.InvariantCulture)} - {categoria}");
    }
}