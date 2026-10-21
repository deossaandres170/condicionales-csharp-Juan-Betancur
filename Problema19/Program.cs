using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la velocidad medida (km/h): ");
        int velocidad = int.Parse(Console.ReadLine());

        string sancion = velocidad < 0 ? "Lectura inválida" :
                         velocidad <= 50 ? "Sin infracción" :
                         velocidad <= 70 ? "Multa leve" :
                         velocidad <= 90 ? "Multa grave" : "Multa gravísima e inmovilización";

        Console.WriteLine(sancion);
    }
}