using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el operador (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double resultado = op switch
            {
                '+' => n1 + n2,
                '-' => n1 - n2,
                '*' => n1 * n2,
                '/' => n2 == 0 ? throw new DivideByZeroException("No se puede dividir entre cero") : (double)n1 / n2,
                _ => throw new InvalidOperationException("Operador no soportado")
            };

            Console.WriteLine($"Resultado: {n1} {op} {n2} = {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.Message}");
        }
    }
}