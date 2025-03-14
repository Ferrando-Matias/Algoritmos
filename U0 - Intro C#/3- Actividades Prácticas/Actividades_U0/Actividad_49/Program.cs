/* Enunciado:
             * 49)	Pedir al usuario que ingrese una lista de números enteros
             * y luego encontrar la posición del elemento mínimo y máximo en la lista.
             */

Console.WriteLine("Ingresa una lista de números enteros separados por comas:");
string input = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en una lista de enteros
List<int> lista = new List<int>(Array.ConvertAll(input.Split(','), int.Parse));

// Encontrar la posición del elemento mínimo
int posicionMinimo = 0;

for (int i = 1; i < lista.Count; i++)
{
    if (lista[i] < lista[posicionMinimo])
    {
        posicionMinimo = i;
    }
}

// Encontrar la posición del elemento máximo
int posicionMaximo = 0;

for (int i = 1; i < lista.Count; i++)
{
    if (lista[i] > lista[posicionMaximo])
    {
        posicionMaximo = i;
    }
}

// Mostrar la posición del elemento mínimo y máximo
Console.WriteLine("Posición del elemento mínimo: " + posicionMinimo);
Console.WriteLine("Posición del elemento máximo: " + posicionMaximo);
Console.ReadKey();