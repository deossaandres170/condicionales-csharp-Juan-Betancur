using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el rol (admin, instructor, aprendiz): ");
        string rol = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la hora de llegada (0 a 23): ");
        int hora = int.Parse(Console.ReadLine());

        bool accesoPermitido = rol switch
        {
            "admin" => true,
            "instructor" when hora >= 6 && hora <= 21 => true,
            "aprendiz" when hora >= 6 && hora <= 18 => true,
            _ => false
        };

        if (accesoPermitido)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
}