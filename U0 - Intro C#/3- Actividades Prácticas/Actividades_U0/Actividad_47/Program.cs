/* Enunciado:
             * 47)	Pedir al usuario que ingrese una lista de números 
             * enteros y luego eliminar cualquier elemento duplicado.
             */

Console.WriteLine("Ingresa una lista de números enteros separados por comas:");
string input = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en una lista de enteros
List<int> numeros = new List<int>();
string[] numerosString = input.Split(',');
foreach (string numeroString in numerosString)
{
    int numero;
    if (int.TryParse(numeroString, out numero))
    {
        numeros.Add(numero);
    }
    else
    {
        Console.WriteLine($"'{numeroString}' no es un número entero válido y será ignorado.");
    }
}

// Eliminar elementos duplicados sin usar una segunda lista
for (int i = 0; i < numeros.Count; i++)
{
    int elementoActual = numeros[i];
    for (int j = i + 1; j < numeros.Count; j++)
    {
        if (numeros[j] == elementoActual)
        {
            numeros.RemoveAt(j);
            j--;
        }
    }
}

// Mostrar los números sin duplicados
Console.WriteLine("Números sin duplicados:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
Console.ReadKey();