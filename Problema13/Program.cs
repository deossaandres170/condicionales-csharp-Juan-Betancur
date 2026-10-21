using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el código de país (ej. CO, MX): ");
        string codigo = Console.ReadLine().Trim().ToUpper();

        string pais = codigo switch
        {
            "CO" => "Colombia",
            "MX" => "México",
            "AR" => "Argentina",
            "PE" => "Perú",
            "CL" => "Chile",
            _ => "País no registrado"
        };

        Console.WriteLine(pais);
    }
}