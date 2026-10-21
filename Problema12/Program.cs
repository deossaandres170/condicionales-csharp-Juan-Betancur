using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Tiene empleo? (s/n): ");
        bool tieneEmpleo = Console.ReadLine().Trim().ToLower() == "s";

        if (!tieneEmpleo)
        {
            Console.WriteLine("Crédito rechazado");
        }
        else
        {
            Console.Write("Ingrese su ingreso mensual: ");
            decimal ingreso = decimal.Parse(Console.ReadLine());

            if (ingreso >= 2500000)
            {
                Console.WriteLine("Crédito alto aprobado");
            }
            else
            {
                Console.WriteLine("Crédito básico aprobado");
            }
        }
    }
}