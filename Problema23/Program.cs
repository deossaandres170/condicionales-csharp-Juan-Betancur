using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese usuario: ");
        string usuario = Console.ReadLine();

        if (usuario != "aprendiz")
        {
            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.Write("Ingrese contraseña: ");
            string password = Console.ReadLine();

            if (password == "Sena2026")
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
    }
}