using System;

Console.WriteLine("¿Ingrese su edad en años? :");

int edadPersona = int.Parse(Console.ReadLine());


if (edadPersona >= 16)
{
    Console.WriteLine("La persona cumple con la edad para votar");
}
else
{
    Console.WriteLine("La persona NO cumple con la edad para votar");
}