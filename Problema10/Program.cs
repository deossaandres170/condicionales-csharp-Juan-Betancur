using System;

class Program
{
    static void Main()
    {
        // Ejemplo con texto; se puede cambiar para probar otros tipos
        object dato = "SENA";

        string resultado = dato switch
        {
            string s => $"Texto de {s.Length} caracteres",
            int i => $"Entero: {i}",
            double d => $"Decimal: {d}",
            bool b => $"Booleano: {b}",
            _ => "Tipo no reconocido"
        };

        Console.WriteLine(resultado);
    }
}