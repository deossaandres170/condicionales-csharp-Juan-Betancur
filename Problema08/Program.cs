using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una letra minúscula: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (!char.IsLetter(c) || c != char.ToLower(c))
        {
            Console.WriteLine("No es una letra minúscula válida");
        }
        else
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es vocal");
                    break;
                default:
                    Console.WriteLine("Es consonante");
                    break;
            }
        }
    }
}