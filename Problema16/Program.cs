using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese coordenada X: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese coordenada Y: ");
        int y = int.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origen");
        }
        else if (x == 0 || y == 0)
        {
            Console.WriteLine("Sobre un eje");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Primer cuadrante");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Segundo cuadrante");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Tercer cuadrante");
        }
        else
        {
            Console.WriteLine("Cuarto cuadrante");
        }
    }
}