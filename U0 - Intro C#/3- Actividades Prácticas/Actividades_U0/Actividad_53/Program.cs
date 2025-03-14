/* Enunciado:
            * 53)	Pedir al usuario que ingrese una lista de números 
            * enteros y luego ordenarla de manera ascendente o descendente.
            */

Console.WriteLine("Ingresa una lista de números enteros separados por comas:");
string input = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en una lista de enteros
List<int> lista = new List<int>(Array.ConvertAll(input.Split(','), int.Parse));


Console.WriteLine("¿Deseas ordenar la lista de manera ascendente (A) o descendente (D)?");
string opcion = Console.ReadLine();

if (opcion.ToUpper() == "A")
{
    int n = lista.Count();

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (lista[j] > lista[j + 1])
            {
                int temp = lista[j];
                lista[j] = lista[j + 1];
                lista[j + 1] = temp;
            }
        }
    }
}
else if (opcion.ToUpper() == "D")
{
    int n = lista.Count();

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (lista[j] < lista[j + 1])
            {
                int temp = lista[j];
                lista[j] = lista[j + 1];
                lista[j + 1] = temp;
            }
        }
    }
}
else
{
    Console.WriteLine("Opción no válida. No se realizará ninguna ordenación.");
}

// Mostrar la lista ordenada
Console.WriteLine("Lista ordenada:");
foreach (int numero in lista)
{
    Console.WriteLine(numero);
}

Console.ReadKey();