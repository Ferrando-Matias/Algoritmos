/* Enunciado:
             * Crea un programa que solicite al usuario el tamaño de un array 
             * y los valores para cada uno de sus elementos. Luego, el programa 
             * debe encontrar el elemento que aparece con mayor frecuencia en
             * el array y mostrarlo en la consola.
             */

Console.Write("Ingrese el tamaño del array: ");
int tamaño = int.Parse(Console.ReadLine());

int[] arr = new int[tamaño];

// Solicita los valores para cada elemento del array
for (int i = 0; i < tamaño; i++)
{
    Console.Write($"Ingrese el valor para el elemento {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

int contMax = 0;
int mayorFrecuencia = arr[0];

// Busca el elemento con mayor frecuencia en el array
for (int i = 0; i < tamaño; i++)
{
    int cont = 0;
    for (int j = 0; j < tamaño; j++)
    {
        if (arr[j] == arr[i])
        {
            cont++;
        }
    }
    if (cont > contMax)
    {
        contMax = cont;
        mayorFrecuencia = arr[i];
    }
}

Console.WriteLine($"El elemento que aparece con mayor frecuencia" +
$" en el array es {mayorFrecuencia}, con una frecuencia de {contMax}");


Console.ReadKey();