/* Enunciado:
             * 54)	Pedir al usuario que ingrese una lista de números enteros
             * y luego invertir el orden de los elementos en la lista.
             */
Console.WriteLine("Ingresa una lista de números enteros separados por comas:");
string input = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en una lista de enteros
List<int> numeros = new List<int>(Array.ConvertAll(input.Split(','), int.Parse));

// Invertir el orden de los elementos en la lista
int longitud = numeros.Count();
int mitad = longitud / 2;

for (int i = 0; i < mitad; i++)
{
    int temp = numeros[i];
    numeros[i] = numeros[longitud - 1 - i];
    numeros[longitud - 1 - i] = temp;
}

// Mostrar la lista invertida
Console.WriteLine("Lista invertida:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
Console.ReadKey();