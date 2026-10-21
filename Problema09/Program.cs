using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        int anio = int.Parse(Console.ReadLine());

        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            Console.WriteLine("Bisiesto");
        }
        else
        {
            Console.WriteLine("No bisiesto");
        }
    }
}