using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de la compra: ");
        decimal compra = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("¿Es cliente frecuente? (s/n): ");
        bool frecuente = Console.ReadLine().Trim().ToLower() == "s";

        decimal descuentoBase = compra >= 500000 ? 0.15m :
                               compra >= 200000 ? 0.10m :
                               compra >= 100000 ? 0.05m : 0.0m;

        decimal descuentoAdicional = (frecuente && compra >= 100000) ? 0.05m : 0.0m;
        decimal descuentoTotal = descuentoBase + descuentoAdicional;

        decimal totalPagar = compra * (1 - descuentoTotal);

        Console.WriteLine($"Valor compra: ${compra:N0} | Descuento total: {descuentoTotal * 100}% | Total a pagar: ${totalPagar:N0}");
    }
}