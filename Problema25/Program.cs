using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el ICA (Índice de Calidad del Aire): ");
        int ica = int.Parse(Console.ReadLine());

        string categoria = ica < 0 ? "Valor inválido" :
                           ica <= 50 ? "Buena" :
                           ica <= 100 ? "Moderada" :
                           ica <= 150 ? "Dañina para grupos sensibles" :
                           ica <= 200 ? "Dañina" : "Muy dañina";

        Console.WriteLine(categoria);
    }
}