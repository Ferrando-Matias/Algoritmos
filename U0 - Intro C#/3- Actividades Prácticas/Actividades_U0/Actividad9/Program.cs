// Enunciado: 9) Crear un menú de opciones
Console.WriteLine("Seleccione una opcion: \n" +
    "a - Opcion 1\n" +
    "b - Opcion 2\n" +
    "c - Opcion 3\n" +
    "d - Opcion 4");
string opcion = Console.ReadLine();
switch (opcion)
{
    case "a":
        Console.WriteLine("Selecciono la opcion 1");
        break;
    case "b":
        Console.WriteLine("Selecciono la opcion 2");
        break;
    case "c":
        Console.WriteLine("Selecciono la opcion 3");
        break;
    case "d":
        Console.WriteLine("Selecciono la opcion 4");
        break;
    default:
        Console.WriteLine("La opcion seleccionada no existe");
        break;
}
Console.ReadKey();