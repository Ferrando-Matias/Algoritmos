/* Enunciado:
             * 41)	Crea un programa que solicite al usuario el tamaño 
             * de un array y los valores para cada uno de sus elementos.
             * Luego, el programa debe encontrar el segundo elemento 
             * más grande del array y mostrarlo en la consola.
             */

Console.Write("Ingrese el tamaño del array: ");
int tamaño = int.Parse(Console.ReadLine());

int[] array = new int[tamaño];

Console.WriteLine("Ingrese los valores para el array:");
for (int i = 0; i < tamaño; i++)
{
    Console.Write($"Valor {i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
}

int max = int.MinValue;
int segundoMax = int.MinValue;

for (int i = 0; i < tamaño; i++)
{
    if (array[i] > max)
    {
        segundoMax = max;
        max = array[i];
    }
    else if (array[i] > segundoMax && array[i] < max)
    {
        segundoMax = array[i];
    }
}

if (segundoMax == int.MinValue)
{
    Console.WriteLine("No se encontró un segundo elemento más grande.");
}
else
{
    Console.WriteLine("El segundo elemento más grande del array es: " + segundoMax);
}
Console.ReadKey();