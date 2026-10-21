using System;

Console.WriteLine("""
========== Menú del cajero ==========
1 = Consultar saldo
2 = Retirar
3 = Depositar
4 = Salir.
""");

Console.WriteLine("Seleccione una opción del menú (1, 2, 3, 4):");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado: Consultar saldo");
        break;
    case 2:
        Console.WriteLine("Ha seleccionado: Retirar");
        break;
    case 3:
        Console.WriteLine("Ha seleccionado: Depositar");
        break;
    case 4:
        Console.WriteLine("Ha seleccionado: Salir");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}