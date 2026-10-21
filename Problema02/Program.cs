using System;

Console.WriteLine("¿Ingrese el peso del paquete en kilogramos?:");

decimal pesoPaquete = decimal.Parse(Console.ReadLine());

if (pesoPaquete <= 0)
{
    Console.WriteLine("Peso inválido, tarifa: $0");
}
else
{
    decimal tarifa = pesoPaquete switch
    {
        < 1 => 8000m,
        >= 1 and < 5 => 15000m,
        >= 5 and < 20 => 32000m,
        >= 20 => 60000m
    };

    Console.WriteLine($"La tarifa del paquete es de ${tarifa:N0}");
}