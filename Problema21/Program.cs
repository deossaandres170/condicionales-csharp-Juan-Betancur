using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de artículos: ");
        int articulos = int.Parse(Console.ReadLine());

        string mensaje = $"Tienes {articulos} {(articulos == 1 ? "artículo" : "artículos")} en el carrito";

        Console.WriteLine(mensaje);
    }
}