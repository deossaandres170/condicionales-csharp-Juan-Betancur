using System;

enum Semaforo { Rojo, Amarillo, Verde }

class Program
{
    static void Main()
    {
        Semaforo estado = Semaforo.Rojo; // Cambiar para probar

        switch (estado)
        {
            case Semaforo.Rojo:
                Console.WriteLine("Deténgase");
                break;
            case Semaforo.Amarillo:
                Console.WriteLine("Precaución, prepárese para detenerse");
                break;
            case Semaforo.Verde:
                Console.WriteLine("Avance");
                break;
        }
    }
}